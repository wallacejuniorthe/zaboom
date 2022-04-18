import axios from 'axios';
import {urls} from '../constants/Urls'
import { ApiResponse, LoginKey } from '../types';

const getCookie = (headers:any)=>{
    let refreshToken:string = headers['set-cookie'][0];            
    refreshToken = refreshToken.split('=')[1];
    refreshToken = refreshToken.split(';')[0];

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
        result.data=response.data;
        if(result.data.isVerified){
            result.cookie=getCookie(response.headers);
        }
    } catch(error){
        result.success = false;
        result.data = error.response.data;
        return Promise.reject(result);
    }

    return Promise.resolve(result);
}

export async function refreshingToken(refreshToken:string):Promise<ApiResponse> {
    
    var result:ApiResponse = {};
    
    var obj ={
        refreshToken
      };


    try{
        const response = await axios.post(urls.REFRESH_TOKEN,obj);
        result.success=true;
        result.data=response.data;
        result.cookie=getCookie(response.headers);

    } catch(error){
        result.success = false;
        result.data = error.response.data;
    }
    return result;
}


export async function registerUser(name: string, email:string,phone1:string,password: string,
    confirmPassword: string):Promise<ApiResponse> {

    var result:ApiResponse = {};
    var obj ={name,email,phone1,password,confirmPassword};
    
    try{
        const response = await axios.post(urls.REGISTER_USER,obj);
        result.data = response.data;
    } catch(error){
        result.data = error.response.data;
        return Promise.reject(result);
    }
    return Promise.resolve(result);
}

export async function requestResetPassword(email:string):Promise<ApiResponse> {

    var result:ApiResponse = {}
    var obj ={email};
   
    try{
        const response = await axios.post(urls.FORGET_PASSWORD,obj);
        result.data = response.data;
    } catch(error){
        return Promise.reject(result);
    }

    return Promise.resolve(result);
}

export async function resetPassword(code:string,password:string,confirmPassword:string):Promise<ApiResponse> {

    var result:ApiResponse = {}
    var obj ={code,password,confirmPassword};
    try{
        const response = await axios.post(urls.RESET_PASSWORD,obj);
        result.data = response.data;
    } catch(error){
        result.data = error.response.data;
        return Promise.reject(result);
    }
    return Promise.resolve(result);
}

export async function validateAccount(id:number,token:string):Promise<ApiResponse> {

    var result:ApiResponse = {}
    var obj ={id,token};
   
    try{
        const response = await axios.post(urls.VERIFY_ACCOUNT,obj);
        result.data = response.data;
    } catch(error){
        result.data = error.response.data;
        return Promise.reject(result);
    }
    return Promise.resolve(result);
}

export async function resendVerificationToken(id:number):Promise<ApiResponse> {

    var result:ApiResponse = {}
    var obj ={id};
   
    try{
        const response = await axios.post(urls.RESEND_VERIFICATION_TOKEN,obj);
        result.data = response.data;
    } catch(error){
        result.data = error.response.data;
        return Promise.reject(result);
    }
    return Promise.resolve(result);
}


