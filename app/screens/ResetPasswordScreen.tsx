import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import { RootTabScreenProps,StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import {resetPassword} from '../services/authService';
import * as val from '../utils/validations';
import LabelTextInput from '../components/forms/LabetlTextInput';
import {messages} from '../constants/Message'
import Validation from '../components/forms/Validation';

export default function ResetPasswordScreen({ navigation }: RootTabScreenProps<'ResetPassword'>) {

  const [errorMessage, setErrorMessage] = React.useState<string | null>(null);
  const [successMessage, setSuccessMessage] = React.useState<string | null>(null);
  const [alertMessage, setAlertMessage] = React.useState<string | null>(null);

  const [code, setCode] = React.useState<string | null>(null);
  const [codeErrorMessage, setCodeErrorMessage] = React.useState<string | null>(null);
  const [password, setPassword] = React.useState<string | null>(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState<string | null>(null);
  const [confirmPassword, setConfirmPassword] = React.useState<string | null>(null);
  const [confirmPasswordErrorMessage, setConfirmPasswordErrorMessage] = React.useState<string | null>(null);


  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      setAlertMessage("Você receberá em instantes um e-mail com um código de verificação");
      setCode("560591");
      setPassword("123456");
      setConfirmPassword("123456");
    });
  return unsubscribe;
  }, [navigation]);
  

  const onLogin = async ()=>{

    let isFormValid = true;
    setCodeErrorMessage(null);
    setPasswordErrorMessage(null);
    setConfirmPasswordErrorMessage(null);
    setErrorMessage(null);
    setSuccessMessage(null);
    setAlertMessage(null)

    if (val.isEmpty(code)) {
      setCodeErrorMessage("Informe o código recebido");
      isFormValid = false;
    }

    if (!val.isPasswordValid(password)) {
      setPasswordErrorMessage("Informe sua nova senha");
      isFormValid = false;
    }

    if (!val.isPasswordValid(confirmPassword)) {
      setConfirmPasswordErrorMessage("Confirme sua nova senha");
      isFormValid = false;
    }

    if (password!==confirmPassword) {
      setConfirmPasswordErrorMessage("As senhas informadas não coincidem");
      isFormValid = false;
    }


    if(isFormValid){
      resetPassword(code,password,confirmPassword).then((result)=>{
        navigation.navigate("Login",{successMessageParam:result.data.message});
      }).catch((result)=>{ 
        setErrorMessage(result.data.message);
      });
    }
  };

  return(
    
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={styles.logo}/>

        <Validation errorMessage={errorMessage} successMessage={successMessage} alertMessage={alertMessage}></Validation>

        <LabelTextInput placeholder="Informe o código recebido" 
        setFunction={setCode} errorMessage={codeErrorMessage} value={code}></LabelTextInput>

        <LabelTextInput placeholder="Nova senha" secureTextEntry
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password}></LabelTextInput>

        <LabelTextInput placeholder="Confirme sua nova senha" secureTextEntry
        setFunction={setConfirmPassword} errorMessage={confirmPasswordErrorMessage} value={confirmPassword}></LabelTextInput>

        {!successMessage &&
          <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>onLogin()}>
            <Text style={defautStyles.loginText}>Alterar senha</Text>
          </TouchableOpacity>
        }
        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>{
          navigation.navigate("Login");
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

