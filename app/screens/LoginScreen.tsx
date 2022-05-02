import React, { useEffect, useState } from 'react';
import { StyleSheet, Button, TouchableOpacity, Image, ActivityIndicator } from 'react-native';
import { Text, View, TextInput } from '../components/Themed';
import { DefaultStyles as defautStyles } from '../styles/styles'
import colors from '../constants/Colors'
import * as val from '../utils/validations';
import LabelTextInput from '../components/forms/LabetlTextInput';
import Validation from '../components/forms/Validation';
import TouchableButton from '../components/forms/TouchableButton';
import { useAuth } from '../hooks/authContext';
import { authenticateUser } from '../services/authService';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { LoginKey, RefreshTokenKey } from '../types';
import { setLogin } from '../services/TokenService';

export default function LoginScreen({ route, navigation }) {

  const { user, signIn, signOut } = useAuth();

  const [errorMessage, setErrorMessage] = React.useState<string | null>(null);
  const [successMessage, setSuccessMessage] = React.useState<string | null>(null);
  const [isLoading, setLoading] = useState(false);

  const [email, setEmail] = React.useState<string | null>(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState<string | null>(null);
  const [password, setPassword] = React.useState<string | null>(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState<string | null>(null);

  const clearForm = () => {
    setErrorMessage(null);
    setEmail(null);
    setPassword(null);
  }

  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      //Verify if exists messages in props
      try {
        const successMessageParam = route.params.successMessageParam;
        setSuccessMessage(successMessageParam);
      } catch (error) {
      };
      signOut();
    });

    setEmail("User1@teste.com");
    setPassword("123456");

    return unsubscribe;
  }, [route, navigation]);

  const onLogin = async () => {

    setLoading(true);
    let isFormValid = true;
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setErrorMessage(null);

    if (!val.isEmail(email, true)) {
      setEmailErrorMessage("Email inválido");
      isFormValid = false;
    }

    if (!val.isPasswordValid(password)) {
      setPasswordErrorMessage("Senha inválido");
      isFormValid = false;
    }

    if (isFormValid) {
      try {
        var response = await authenticateUser(email as string, password as string);
        console.log(response.data);
        if ((response.data.isVerified as boolean)) {
          setLogin(response);
          signIn();
        } else {
          navigation.navigate("Registered",{ 
            id:response.data.id, 
            name:response.data.name
          });
          console.log('não validado');
        }
      } catch (error) {
        console.log(error);
        setErrorMessage(error.data.message);
      } finally {
        setLoading(false);
      }
    }

  };

  return (

    <View style={defautStyles.container}>
      <Image source={require('../assets/images/logo.png')} style={defautStyles.logo} />

      <Validation errorMessage={errorMessage} successMessage={successMessage}></Validation>

      <LabelTextInput placeholder="Email"
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>

      <LabelTextInput placeholder="Senha"
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password} secureTextEntry></LabelTextInput>

      <TouchableButton isLoading={isLoading} style={defautStyles.loginBtn} onPress={() => onLogin()}
        Text="Entrar" TextStyle={defautStyles.loginText}
      ></TouchableButton>

      <TouchableOpacity onPress={() => {
        navigation.navigate('ForgetPassword');
      }}>
        <Text style={defautStyles.forgot}>Esqueceu sua senha?</Text>
      </TouchableOpacity>

      <TouchableOpacity style={defautStyles.loginRegister} onPress={() => {
        navigation.navigate('Register');
      }}>
        <Text style={defautStyles.loginText}>Faça seu cadastro</Text>
      </TouchableOpacity>


    </View>
  )
}

const styles = StyleSheet.create({
});

