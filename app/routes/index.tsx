import {View, ActivityIndicator} from 'react-native';
import {useAuth} from '../hooks/authContext';
import AuthRoutes from './auth.routes';
import AppRoutes from './app.routes';

const Routes = () => {
  const {signed, loading,checkAuth} = useAuth();

  if (loading) {
    return (
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <ActivityIndicator size="large" color="#666" />
      </View>
    );
  }

  console.log('signed ');
  checkAuth();
  return signed ? <AppRoutes /> : <AuthRoutes />;
};

export default Routes;