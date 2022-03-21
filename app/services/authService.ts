import axios from 'axios';
import {urls} from '../constants/Urls'
import { ApiResponse, Nullable } from '../types';

class AuthService  {

    authenticateUser = async (login: string, password: string) => {

        var result = new ApiResponse();
        var obj ={
            email:login,
            password:password
        };

        try{
            const response = await axios.post(urls.AUTHENTICATE,obj);
            result.success = true;
            result.data = response.data;

            var refreshToken:string = "";
            try{
                 refreshToken = response.headers['set-cookie'][0];            
                 refreshToken = refreshToken.split(';')[0];
                 refreshToken = refreshToken.split('=')[1];
                 result.cookie = refreshToken;
            }
            catch(error){
                result.success = false;
                result.data = "Não foi possível acessar o cookie";
            }
        } catch(error){
            result.success = false;
            result.data = error.response.data;
        }

        return result;
    }

    registerUser = async (name: string, email:string,password: string,
        confirmPassword: string):Promise<ApiResponse> => {

        var result = new ApiResponse();
        
        var obj ={
            name,email,password,confirmPassword
        };
        
        try{
            const response = await axios.post(urls.REGISTER_USER,obj);
            result.success = true;
            result.data = response.data;
        } catch(error){
            result.success = false;
            result.data = error.response.data;
        }
        return result;
    }

}


export  {
    AuthService
};