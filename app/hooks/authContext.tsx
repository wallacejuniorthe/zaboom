import {createContext, useState, useEffect, useContext, Props} from 'react';
import * as authservice from '../services/authService';
import { ApiResponse, ILogin, LoginKey, RefreshTokenKey } from '../types';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { AxiosInstance } from 'axios';
import jwtDecode, { JwtPayload } from 'jwt-decode';
import { View,Text } from 'react-native';

/*
interface User {
  name: string;
  email: string;
}*/

interface AuthContextData {
  signed: boolean;
  user: ILogin | null;
  loading: boolean;
  signIn(login: string, password: string):Promise<void>;
  signOut(): void;
  getApiRequest():AxiosInstance;
  incrementCounter():void;
}

const AuthContext = createContext<AuthContextData>({} as AuthContextData);

const AuthProvider = ({children}:Props) => {

  const [user, setUser] = useState<ILogin | null>(null);
  const [loading, setLoading] = useState(true);
  const [counter, setCounter] = useState(0);


  useEffect(() => {
    
    async function loadStorageData() {

      const storagedUser = await AsyncStorage.getItem(LoginKey);
      const storagedRefeshToken = await AsyncStorage.getItem(RefreshTokenKey);

      if (storagedUser && storagedRefeshToken) {
        const login:ILogin = storagedUser as ILogin;
        const decoded = jwtDecode<JwtPayload>(login.token);
        
        if (Date.now() <= decoded.exp * 1000) {
          setUser(login);
          console.log('Token ok');
        }
        console.log('Não logado');
      }
      setLoading(false);
    }
    loadStorageData();
    setLoading(false);
  });


  async function signIn(login: string, password: string):Promise<void> {

//    console.log('Entrando.....sing');

    try{
      var response = await authservice.authenticateUser(login,password);
      
      await AsyncStorage.clear();

      var loginResponse:ILogin = {
        token:response.data.jwtToken,
        user:{
          id:response.data.id,
          name:response.data.name,
          email:response.data.email,
          role:response.data.role,
        }
      };

      await AsyncStorage.setItem(LoginKey,JSON.stringify(loginResponse));
      await AsyncStorage.setItem(RefreshTokenKey,response.cookie);
      setUser(loginResponse);

    } catch(error){
        console.log(error);
    }

  }

  function incrementCounter(){
    if(counter>4)
    {
      signOut();
    }
    setCounter(counter+1);

  }
  async function signOut() {
    await AsyncStorage.clear();
    setUser(null);
  }

    
  return (
    <AuthContext.Provider
              value={{signed: !!user, user, loading,signIn,signOut,incrementCounter}}>
               <View style={{marginTop:70}}>
                 <Text>{counter}</Text>
               </View>
    {children}
  </AuthContext.Provider>
  );
};

function useAuth() {
  const context = useContext(AuthContext);

  if (!context) {
    throw new Error('useAuth must be used within an AuthProvider.');
  }

  return context;
}

export {AuthProvider, useAuth};

