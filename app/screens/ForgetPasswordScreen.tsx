import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import { RootTabScreenProps,StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import {AuthService} from '../services/authService';
import * as val from '../utils/validations';
import LabelTextInput from '../components/forms/LabetlTextInput';
import {messages} from '../constants/Message'

export default function ForgetPasswordScreen({ navigation }: RootTabScreenProps<'ForgetPassword'>) {

  const [errorMessage, setErrorMessage] = React.useState(null);

  const [email, setEmail] = React.useState(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState(null);
  
  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
    //  clearForm();
    });
    setEmail("teste@teste.com");
  return unsubscribe;
  }, [navigation]);
  

  const onLogin = async ()=>{

    let isFormValid = true;
    setEmailErrorMessage(null);

    if(!val.isEmail(email,true)) {
      setEmailErrorMessage("Email inválido");
      isFormValid = false;
    }

    if(isFormValid){
      const authService = new AuthService();
      var result = await authService.resetPassword(email);
      
     if(!result.success){
        setErrorMessage(messages.ERRO_REQUISICAO);
      }else{
        console.log(result.data);
      }
    }

  };

  return(
    
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={styles.logo}/>
       
        <LabelTextInput placeholder="Email" 
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>

        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>onLogin()}>
          <Text style={defautStyles.loginText}>Recuperar senha</Text>
        </TouchableOpacity>
        
        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>{
          navigation.goBack();
        }}>
          <Text style={defautStyles.loginText}>Voltar</Text>
        </TouchableOpacity>
  
      </View>
  )

}

const styles = StyleSheet.create({
  logo:{
    height:100,
    width:250
  },
  
});

