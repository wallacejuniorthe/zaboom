import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import { RefreshTokenKey, RootTabScreenProps,StorageKey, TokenKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import {AuthService} from '../services/authService';
import * as val from '../utils/validations';
import axios from 'axios';
import LabelTextInput from '../components/forms/LabetlTextInput';
import { useFocusEffect } from '@react-navigation/native';

export default function LoginScreen({ navigation })  {

  const [errorMessage, setErrorMessage] = React.useState(null);

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
    //  clearForm();
    });
    setEmail("teste@teste.com");
    setPassword("123456");
  return unsubscribe;
  }, [navigation]);
  


  const onLogin = async ()=>{
    
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
      const authService = new AuthService();
      var result = await authService.authenticateUser(email,password);
      //console.log(result);
      if(!result.success){
        setErrorMessage("Usuário ou senha inválidos");
      }else{
        await SecureStore.deleteItemAsync(RefreshTokenKey);
        await SecureStore.deleteItemAsync(TokenKey);
        await SecureStore.setItemAsync(RefreshTokenKey,result.cookie);
        await SecureStore.setItemAsync(TokenKey,JSON.stringify(result.data));

        SecureStore.getItemAsync(TokenKey).then((value)=>{
          console.log(value);
        });

      }
    }
  };

  return(
    
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={defautStyles.logo}/>

        {errorMessage &&
        <View style={defautStyles.errorMessageView}>
            <Text style={defautStyles.errorMessage}>{errorMessage}</Text>
        </View>
        }
        <LabelTextInput placeholder="Email" 
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>
        
        <LabelTextInput placeholder="Senha" 
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password} secureTextEntry></LabelTextInput>

        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>onLogin()}>
          <Text style={defautStyles.loginText}>Entrar</Text>
        </TouchableOpacity>

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

