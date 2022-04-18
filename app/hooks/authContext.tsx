import {createContext, useState, useEffect, useContext, Props} from 'react';
import { ILogin, LoginKey, RefreshTokenKey } from '../types';
import AsyncStorage from '@react-native-async-storage/async-storage';

interface AuthContextData {
  signed:boolean;
  user: ILogin | null;
  loading: boolean;
  signIn():Promise<void>;
  signOut(): void;
  checkAuth():void;
}


const AuthContext = createContext<AuthContextData>({} as AuthContextData);

const AuthProvider = ({children}:Props) => {

  const [signed, setSigned] = useState<boolean>(false);
  const [user, setUser] = useState<ILogin | null>(null);
  const [loading, setLoading] = useState(true);


  async function loadStorageData() {

    try{
      const storagedUser = await AsyncStorage.getItem(LoginKey);
      const storagedRefeshToken = await AsyncStorage.getItem(RefreshTokenKey);

      if (storagedUser && storagedRefeshToken) {
        const login:ILogin = storagedUser as ILogin;
        setUser(login);
      }

    } catch(error){
      setUser(null);
      setSigned(false);
      await AsyncStorage.clear();
    }
  }

  useEffect(() => {
    setLoading(true);
    loadStorageData();
    setLoading(false);

    console.log('useEffect(() => { '+Date());
  });


  async function signIn():Promise<void> {
    setSigned(true);
  }

  async function signOut() {
    try{
      setUser(null);
      setSigned(false);
      await AsyncStorage.clear();
    } catch(error){
     
    }

  }

  async function checkAuth() {
    console.log('checkAuth()'+Date());
    let user = await AsyncStorage.getItem(LoginKey);
    let resultado:boolean = user?true:false;
    setSigned(resultado);
    console.log('signed '+resultado+ Date());
  }

  return (
    <AuthContext.Provider
              value={{signed,user, loading,signIn,signOut,checkAuth}}>
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

