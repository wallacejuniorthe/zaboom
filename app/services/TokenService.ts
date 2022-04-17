import { ApiResponse, LoginKey, RefreshTokenKey } from '../types';
import AsyncStorage from '@react-native-async-storage/async-storage';

export async function setLogin(response:ApiResponse) {
    
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
}

export async function setLogout() {
    await AsyncStorage.clear();
}
