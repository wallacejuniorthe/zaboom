/**
 * Learn more about using TypeScript with React Navigation:
 * https://reactnavigation.org/docs/typescript/
 */

import { BottomTabScreenProps } from '@react-navigation/bottom-tabs';
import { CompositeScreenProps, NavigatorScreenParams } from '@react-navigation/native';
import { NativeStackScreenProps } from '@react-navigation/native-stack';

declare global {
  namespace ReactNavigation {
    interface RootParamList extends RootStackParamList {}
  }
}

export type RootStackParamList = {
  Root: NavigatorScreenParams<RootTabParamList> | undefined;
  Modal: undefined;
  NotFound: undefined;
};

export type RootStackScreenProps<Screen extends keyof RootStackParamList> = NativeStackScreenProps<
  RootStackParamList,
  Screen
>;

export type RootTabParamList = {
  TabOne: undefined;
  TabTwo: undefined;
  TabThree: undefined;
  Coupon: undefined;
  CouponActived: undefined;
  Config: undefined;
  CouponDetail: {id:number};
  Login: {successMessageParam?:string};
  Register: undefined;
  Registered: {id?: number,name?:string}
  ForgetPassword: undefined;
  ChangePassword: undefined;
  ResetPassword: undefined;
};

export type RootTabScreenProps<Screen extends keyof RootTabParamList> = CompositeScreenProps<
  BottomTabScreenProps<RootTabParamList, Screen>,
  NativeStackScreenProps<RootStackParamList>
>;

export const StorageKey="jwt8479574";
export const RefreshTokenKey="refreshTokenKey";
export const LoginKey="tokenKey";

export type ApiResponse = {
  success?: boolean | undefined;
  data?: string | undefined;
  cookie?:string | undefined;
};

export type Nullable<T>  = T | null

export interface ILogin {
  token?: string;
  refreshToken?: string;
  user?: {
    id:number,
    name: string;
    email: string;
    role: string
  };
}