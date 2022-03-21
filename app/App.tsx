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

    if(!logado)
    {
      return (
        <SafeAreaProvider>
          <Navigation colorScheme={"ligth"} />
          </SafeAreaProvider>
      );
    }
    else{
      return (
        <SafeAreaProvider>
          <Navigation colorScheme={"ligth"} />
          <StatusBar />
          </SafeAreaProvider>
      );

    }
  }
}
