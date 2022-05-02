import { urls } from '../constants/Urls'
import { ApiResponse, LoginKey } from '../types';
import { apiPost, apiGet } from './apiService';

export async function getUserCoupons(): Promise<ApiResponse> {
    var result: ApiResponse = {}

    try {
        const response = await apiGet(urls.COUPONS_USER);
        result.data = response.data;
    } catch (error) {
        console.log(error);
        //result.data = error.response.data;
        return Promise.reject(error);
    }
    return Promise.resolve(result);
}

export async function getCouponDetail(id:number): Promise<ApiResponse> {
    var result: ApiResponse = {}
    let url = `${urls.COUPON_DETAIL}/${id}`;
    try {
        const response = await apiGet(url);
        result.data = response.data;
    } catch (error) {
        result.data = error.response.data;
        return Promise.reject(error);
    }
    return Promise.resolve(result);
}

export async function activateCoupon(id:number): Promise<ApiResponse> {

    var result: ApiResponse = {}
    var obj = {id};

    let url = `${urls.COUPON_ACTIVATE}`;
    try {
        const response = await apiPost(url,obj);
        result.data = response.data;
    } catch (error) {
        result.data = error.response.data;
        return Promise.reject(error);
    }
    return Promise.resolve(result);
}

