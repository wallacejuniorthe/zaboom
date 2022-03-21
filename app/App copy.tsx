import { StatusBar } from 'expo-status-bar';
import { SafeAreaProvider } from 'react-native-safe-area-context';

import useCachedResources from './hooks/useCachedResources';
import useColorScheme from './hooks/useColorScheme';
import Navigation from './navigation';
import * as SecureStore from 'expo-secure-store';


export default function App() {
  const isLoadingComplete = useCachedResources();
  const colorScheme =  useColorScheme();
  
  SecureStore.setItemAsync("jwt", "123456");
  SecureStore.getItemAsync("jwt").then((obj)=> console.log(obj));


  if (!isLoadingComplete) {
    return null;
  } else {
    return (
      <SafeAreaProvider>
        <Navigation colorScheme={"ligth"} />
        <StatusBar />
      </SafeAreaProvider>
    );
  }
}
