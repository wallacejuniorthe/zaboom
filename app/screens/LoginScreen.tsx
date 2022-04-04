import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image, ActivityIndicator } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import * as val from '../utils/validations';
import LabelTextInput from '../components/forms/LabetlTextInput';
import Validation from '../components/forms/Validation';
import TouchableButton from '../components/forms/TouchableButton';
import { useAuth } from '../hooks/authContext';

export default function LoginScreen({ navigation })  {
  
  const {user, loading,signIn} = useAuth();


  const [errorMessage, setErrorMessage] = React.useState(null);
  const [isLoading, setIsLoading] = useState(false);

  const [email, setEmail] = React.useState(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState(null);
  const [password, setPassword] = React.useState(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState(null);
  
  const clearForm = ()=>{
    setErrorMessage(null);
    setEmail(null);
    setPassword(null);
  }

  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
//       clearForm();
    });
    setEmail("teste@teste.com");
    setPassword("123456");



  return unsubscribe;
  }, [navigation]);
  


  const onLogin = async ()=>{
    
    console.log(user);
    console.log(loading);

    setIsLoading(true);
    let isFormValid = true;
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setErrorMessage(null);

    if(!val.isEmail(email,true)) {
      setEmailErrorMessage("Email inválido");
      isFormValid = false;
    }

    if(!val.isPasswordValid(password,6,12,true)) {
      setPasswordErrorMessage("Senha inválido");
      isFormValid = false;
    }
    
    if(isFormValid){
      try{
        var result = await signIn(email,password);
//        var result = await authService.authenticateUser(email,password);
        //const storagedUser = await AsyncStorage.getItemAsync(LoginKey);

        //console.log(authService.isUserAuthenticated());
/*
        if(!result.success){
          setErrorMessage(result.data);
        }else{
          console.log((await result).data)
        }*/
      }catch(error){
        console.log(error);

      }finally{
      }
    }
    setIsLoading(false);

  };

  return(
    
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={defautStyles.logo}/>

        <Validation errorMessage={errorMessage}></Validation>

        <LabelTextInput placeholder="Email" 
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>
        
        <LabelTextInput placeholder="Senha" 
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password} secureTextEntry></LabelTextInput>

        <TouchableButton isLoading={isLoading} style={defautStyles.loginBtn} onPress={()=>onLogin()}
          Text="Entrar" TextStyle={defautStyles.loginText}
        ></TouchableButton>

        <TouchableOpacity onPress={()=>{
          navigation.navigate('ForgetPassword');
        }}>
          <Text style={defautStyles.forgot}>Esqueceu sua senha?</Text>
        </TouchableOpacity>
        
        <TouchableOpacity style={defautStyles.loginRegister} onPress={()=>{
          navigation.navigate('Register');
        }}>
          <Text style={defautStyles.loginText}>Faça seu cadastro</Text>
        </TouchableOpacity>
        

      </View>

        



  )

}

const styles = StyleSheet.create({
});

