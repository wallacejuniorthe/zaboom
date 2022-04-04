import LoginScreen from '../screens/LoginScreen';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import ForgetPasswordScreen from '../screens/ForgetPasswordScreen';
import RegisteredScreen from '../screens/RegisteredScreen';
import RegisterScreen from '../screens/RegisterScreen';

const AuthStack = createNativeStackNavigator();

const AuthRoutes = () => {

  //console.log('Entrou auth nas rotas');

  return (
    <AuthStack.Navigator>
      <AuthStack.Screen name="Login" component={LoginScreen} options={{ headerShown: false }}/>
      <AuthStack.Screen name="ForgetPassword" component={ForgetPasswordScreen} options={{ headerShown: false}} />
      <AuthStack.Screen name="Register" component={RegisterScreen} options={{ headerShown: false}} />
      <AuthStack.Screen name="Registered" component={RegisteredScreen} options={{ headerShown: false}} />
    </AuthStack.Navigator>
  );
};

export default AuthRoutes;