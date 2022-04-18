import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios'

import { Alert } from 'react-native'
import {urls} from '../constants/Urls'
import { ApiResponse, ILogin, LoginKey,RefreshTokenKey } from '../types';
import { refreshingToken } from '../services/authService'
import { setLogin, setLogout } from './TokenService';



const api = axios.create({
  baseURL: urls.BASEURL,
  headers: {
    'Content-Type': 'application/json',
    Accept: 'application/json',
  }
});

api.interceptors.response.use(
  response => {
    return response
  },
  async error => {
    var requestConfig = error.config
    //console.log(requestConfig);
    if (
      error.request._hasError === true &&
      error.request._response.includes('connect')
    ) {
      Alert.alert(
        'Aviso',
        'Não foi possível conectar aos nossos servidores, sem conexão a internet',
        [ { text: 'OK' } ],
        { cancelable: false },
      )
    }
    
    if (error.response.status === 401 && !requestConfig._retry) {
//      console.log('token expirado '+requestConfig._retry);
      requestConfig._retry = true;
//      console.log('token expirado '+requestConfig._retry);
      
      try{
        const refreshToken = await AsyncStorage.getItem(RefreshTokenKey);
        const rs = await refreshingToken(refreshToken);
        if(rs.success)
        {
          await setLogin(rs);
          return api(requestConfig);
        }

      } catch(error){
        console.log('Error: '+error);
      }
      await setLogout();
//      return api(requestConfig)
    }

    return Promise.reject(error)
  },
)


api.interceptors.request.use(
  async config => {
    try{
      const user = await AsyncStorage.getItem(LoginKey);
      let token = (JSON.parse(user) as ILogin).token;
      if (user && token){
        //console.log('token...'+token);
        config.headers.Authorization = `Bearer ${token}`
      }
      return Promise.resolve(config);
    } catch(error){
      return Promise.resolve(config)
    }
  },
  error => {
    return Promise.reject(error)
  },
)

export async function apiGet(url:string):Promise<ApiResponse>{

  return new Promise((resolve,reject) =>{
    
    var result:ApiResponse = {};

    api.get(url)
    .then(response =>{
        result.success=true;
        result.data=response.data;
        resolve(result);
      })
    .catch(error=>{
        result.success = false;
        result.data = error.response.data;
        reject(result);
    });
  });
}


export async function apiPost(url:string,params):Promise<ApiResponse>{

  return new Promise((resolve,reject) =>{
    
    var result:ApiResponse = {};

    api.post(url,params)
    .then(response =>{
        result.success=true;
        result.data=response.data;
        resolve(result);
      })
    .catch(error=>{
        result.success = false;
        result.data = error.response.data;
        console.log(error.response);
        reject(result);
    });
  });
}

