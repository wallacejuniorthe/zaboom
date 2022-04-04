import axios from 'axios';
import {urls} from '../constants/Urls'
import { ApiResponse, LoginKey } from '../types';

const getCookie = (headers:any)=>{
    let refreshToken:string = headers['set-cookie'][0];            
    refreshToken = 
    refreshToken = refreshToken.split('=')[1];
    return refreshToken;
};

export async function authenticateUser(login: string, password: string):Promise<ApiResponse> {
    
    var result:ApiResponse = {};
    
    var obj ={
        email:login,
        password:password
    };

    try{
        const response = await axios.post(urls.AUTHENTICATE,obj);
        result.success=true;
        result.data=response.data;
        result.cookie=getCookie(response.headers);

    } catch(error){
        result.success = false;
        result.data = error.response.data;
    }

    return result;
}

export async function registerUser(name: string, email:string,password: string,
    confirmPassword: string):Promise<ApiResponse> {

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

export async function resetPassword(email:string):Promise<ApiResponse> {

    var result = new ApiResponse();
    
    var obj ={email};
    
    try{
        const response = await axios.post(urls.FORGET_PASSWORD,obj);
        result.success = true;
        result.data = response.data;
    } catch(error){
        result.success = false;
        result.data = error.response.data;
    }
    return result;
}

export async function changePassword(id:number,password:string,
    newPassword:string):Promise<ApiResponse> {

    var result = new ApiResponse();
    
    var obj ={id,password,newPassword,ConfirmNewPassword:newPassword};
    
    try{
        const response = await axios.post(urls.CHANGE_PASSWORD,obj);
        result.success = true;
        result.data = response.data;
    } catch(error){
        result.success = false;
        result.data = error.response.data;
    }
    return result;
}
