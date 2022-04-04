import {View, ActivityIndicator} from 'react-native';
import {useAuth} from '../hooks/authContext';
import AuthRoutes from './auth.routes';
import AppRoutes from './app.routes';
import React from 'react';

const Routes = () => {
  const {signed, loading} = useAuth();
  console.log('routes...');

  if (loading) {
    return (
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <ActivityIndicator size="large" color="#666" />
      </View>
    );
  }
  return signed ? <AppRoutes /> : <AuthRoutes />;
};

export default Routes;