import AsyncStorage from '@react-native-async-storage/async-storage';
import axios from 'axios'

import { Alert } from 'react-native'
import {urls} from '../constants/Urls'
import { ApiResponse, ILogin, LoginKey } from '../types';
import { createNavigationContainerRef } from '@react-navigation/native';
import * as RootNavigation from '../navigation/rootNavigations';



async function getUser() {
  try {
    return await AsyncStorage.getItem(LoginKey);
  } catch (e) {
    throw e;
  }
}
const api = axios.create({
  baseURL: urls.BASEURL,
  headers: {
    'Content-Type': 'application/json',
    Accept: 'application/json',
  }
});



api.interceptors.response.use(
  response => {

    // Do something with response data

    return response
  },
  error => {

    // Do something with response error

    // You can even test for a response code
    // and try a new request before rejecting the promise

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

    if (error.response.status === 401) {
      const requestConfig = error.config
      console.log('token expirado');
      AsyncStorage.clear()
      .then(result=>{
        
      });

      return axios(requestConfig)
    }

    return Promise.reject(error)
  },
)

api.interceptors.request.use(
  config => {
    console.log('fazendo requiestr');
    RootNavigation.navigate('Root',null);



    return getUser()
      .then(user => {
        if(user)
        {
          let token = (JSON.parse(user) as ILogin).token;
       
          if (user && token)
            config.headers.Authorization = `Bearer ${token}`
          
          return Promise.resolve(config)
        
        } else{

        }
      })
      .catch(error => {
        console.log(error)
        return Promise.resolve(config)
      })
  },
  error => {
    return Promise.reject(error)
  },
)


export async function apiGet(url:string):Promise<ApiResponse>{

  var result:ApiResponse = {};
  
  try {
      const response = await api.get(url);
      result.success=true;
      result.data=response.data;
  } catch(error){
      result.success = false;
      result.data = error.response.data;
      return Promise.reject(result);
  } finally {

  };
 
  return Promise.resolve(result);
}

