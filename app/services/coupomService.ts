import axios from 'axios';
import {urls} from '../constants/Urls'
import { useAuth } from '../hooks/authContext';
import { ApiResponse, LoginKey } from '../types';

export async function getUserCoupons():Promise<ApiResponse> {
    

/*
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
    */

    return result;
}
