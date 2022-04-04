import {AppState, Text} from 'react-native'
import { StatusBar } from 'expo-status-bar';
import { SafeAreaProvider } from 'react-native-safe-area-context';
import useCachedResources from './hooks/useCachedResources';
import useColorScheme from './hooks/useColorScheme';
import Navigation from './navigation';
import * as SecureStore from 'expo-secure-store';
import LoginScreen from './screens/LoginScreen'
import { StorageKey } from './types';
import RegisterScreen from './screens/RegisterScreen';
import Routes from './routes/index';
import { NavigationContainer } from '@react-navigation/native';
import { AuthProvider } from './hooks/authContext';
import { navigationRef } from './navigation/RootNavigations';


export default function App() {
  const isLoadingComplete = useCachedResources();
  const colorScheme =  useColorScheme();
  
  const state = {
    appState: AppState.currentState
  }
//  console.log(state);
  //SecureStore.setItemAsync(StorageKey, "chave xxxxxx");

  if (!isLoadingComplete) {
    return null;
  } else {
    
    let logado = false;

    SecureStore.getItemAsync(StorageKey)
    .then(()=>{
      logado = true;
    });

    
    return (
      <NavigationContainer>
        <AuthProvider>
          <Routes/>
        </AuthProvider>
      </NavigationContainer>
    );

/*
    if(!logado)
    {
      return (
        <AuthContext.Provider value={authContext}>
          <SafeAreaProvider>
            <Navigation colorScheme={"ligth"} />
          </SafeAreaProvider>
       </AuthContext.Provider>
      );
    }
    else{
      return (
        <AuthContext.Provider value={authContext}>
          <SafeAreaProvider>
            <Navigation colorScheme={"ligth"} />
          </SafeAreaProvider>
       </AuthContext.Provider>
      );

    }*/
  }
}
