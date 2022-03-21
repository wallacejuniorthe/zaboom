import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import { RootTabScreenProps,StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import {AuthService} from '../services/authService';
import * as val from '../utils/validations';

export default function RegisterScreenww({ navigation }: RootTabScreenProps<'Login'>) {

  const [errorMessage, setErrorMessage] = React.useState(null);

  const [name, setName] = React.useState(null);
  const [nameErrorMessage, setNameErrorMessage] = React.useState(null);
  const [email, setEmail] = React.useState(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState(null);
  const [password, setPassword] = React.useState(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState(null);
  const [confirmPassword, setConfirmPassword] = React.useState(null);
  const [confirmPasswordErrorMessage, setConfirmPasswordErrorMessage] = React.useState(null);
  
  const onLogin = ()=>{

    let isFormValid = true;
    setNameErrorMessage(null);
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setConfirmPasswordErrorMessage(null);

    if(val.isEmpty(name)) {
      setNameErrorMessage("Nome inválido");
      isFormValid = false;
    }

    if(!val.isEmail(email,true)) {
      setEmailErrorMessage("Email inválido");
      isFormValid = false;
    }

    if(!val.isPasswordValid(password,6,12,true)) {
      setPasswordErrorMessage("Senha inválido");
      isFormValid = false;
    }
    if(!val.isPasswordValid(confirmPassword,6,12,true)) {
      setConfirmPasswordErrorMessage("Confirme sua senha");
      isFormValid = false;
    }

    
    if(isFormValid){
      var obj = {
        email:email,
        password:password,
        name:name,
        confirmPassword:confirmPassword
      };
      console.log(obj);
    }
  };

  return(
    
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={styles.logo}/>

        <View style={defautStyles.inputView} >
          <TextInput  
            style={defautStyles.inputText}
            placeholder="Nome" 
            placeholderTextColor={colors.placeholderTextColor}
            onChangeText={value => setName(value)}
            />
        </View>
        { nameErrorMessage && 
            <Text style={defautStyles.errorMessage}>{nameErrorMessage}</Text>
        }

        <View style={defautStyles.inputView} >
          <TextInput  
            style={defautStyles.inputText}
            placeholder="Email" 
            placeholderTextColor={colors.placeholderTextColor}
            onChangeText={value => setEmail(value)}
            />
        </View>
        { emailErrorMessage && 
            <Text style={defautStyles.errorMessage}>{emailErrorMessage}</Text>
        }
        <View style={defautStyles.inputView} >
          <TextInput  
            secureTextEntry
            style={defautStyles.inputText}
            placeholder="Senha" 
            placeholderTextColor={colors.placeholderTextColor}
            onChangeText={value => setPassword(value)}
            />
        </View>
        { passwordErrorMessage && 
            <Text style={defautStyles.errorMessage}>{passwordErrorMessage}</Text>
        }

        <View style={defautStyles.inputView} >
          <TextInput  
            secureTextEntry
            style={defautStyles.inputText}
            placeholder="Confirme sua senha" 
            placeholderTextColor={colors.placeholderTextColor}
            onChangeText={value => setConfirmPassword(value)}
            />
        </View>
        { confirmPasswordErrorMessage && 
            <Text style={defautStyles.errorMessage}>{confirmPasswordErrorMessage}</Text>
        }
        
        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>onLogin()}>
          <Text style={defautStyles.loginText}>Finalizar cadastro</Text>
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

