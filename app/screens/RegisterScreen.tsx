import React, { useEffect, useState } from 'react';
import { StyleSheet, Button, TouchableOpacity, Image, Pressable, Modal, FlatList } from 'react-native';
import { Text, View, TextInput } from '../components/Themed';
import { RootTabScreenProps, StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import { DefaultStyles as defautStyles } from '../styles/styles'
import colors from '../constants/Colors'
import { registerUser } from '../services/authService';
import * as val from '../utils/validations';
import RNPickerSelect, { defaultStyles } from 'react-native-picker-select';
import { sports } from '../data/data'
import LabelTextInput from '../components/forms/LabetlTextInput';

export default function RegisterScreen({ navigation }: RootTabScreenProps<'Register'>) {

  const [modalVisible, setModalVisible] = useState(false);

  const [errorMessage, setErrorMessage] = React.useState(null);

  const [name, setName] = React.useState(null);
  const [nameErrorMessage, setNameErrorMessage] = React.useState(null);
  const [email, setEmail] = React.useState(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState(null);
  const [password, setPassword] = React.useState(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState(null);
  const [confirmPassword, setConfirmPassword] = React.useState(null);
  const [confirmPasswordErrorMessage, setConfirmPasswordErrorMessage] = React.useState(null);

  const [valor, setValor] = React.useState(null);
  const [valorErrorMessage, setValorErrorMessage] = React.useState(null);


  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      setName("Wallace Junior");
      setEmail("teste@teste.com");
      setPassword("123456");
      setConfirmPassword("123456");
    });
//    console.log('execitou111111');

    return unsubscribe;
  }, [navigation]);
  
  const onLogin = async () => {

    let isFormValid = true;
    setNameErrorMessage(null);
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setConfirmPasswordErrorMessage(null);
    setValorErrorMessage(null);

    if (val.isEmpty(name)) {
      setNameErrorMessage("Nome inválido");
      isFormValid = false;
    }

    if (!val.isEmail(email, true)) {
      setEmailErrorMessage("Email inválido");
      isFormValid = false;
    }

    if (!val.isPasswordValid(password, 6, 12, true)) {
      setPasswordErrorMessage("Senha inválido");
      isFormValid = false;
    }
    if (!val.isPasswordValid(confirmPassword, 6, 12, true)) {
      setConfirmPasswordErrorMessage("Confirme sua senha");
      isFormValid = false;
    }
/*
    if (!valor) {
      setValorErrorMessage("Selecione o condomínio");
      isFormValid = false;
    }*/
    if (isFormValid) {
      var result =  await registerUser(name,email,password,confirmPassword);
      if(!result.success) {
        setErrorMessage('iouiououuiouio');
      } else {
        navigation.navigate('Registered',{name:result.data.name, email: result.data.email});
      }

    }
  };

  return (

    <View style={defautStyles.container}>

      <Image source={require('../assets/images/logo.png')} style={styles.logo} />

      {errorMessage &&
        <View style={defautStyles.errorMessageView}>
            <Text style={defautStyles.errorMessage}>{errorMessage}</Text>
        </View>
        }

      <LabelTextInput placeholder="Nome" 
        setFunction={setName} errorMessage={nameErrorMessage} value={name}></LabelTextInput>

      <LabelTextInput placeholder="Email" 
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>
      
      <LabelTextInput placeholder="Senha" secureTextEntry
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password}></LabelTextInput>

      <LabelTextInput placeholder="Senha" secureTextEntry
        setFunction={setConfirmPassword} errorMessage={confirmPasswordErrorMessage} value={confirmPassword}></LabelTextInput>
  
      <View style={defautStyles.formField}>
        <View style={defautStyles.inputView} >
          <RNPickerSelect
            placeholder={{}}
            items={sports}
            onValueChange={value => {
              setValor(value);
            }}
            InputAccessoryView={() => null}
            style={defautStyles}
            value={valor}
          />
        </View>
        {valorErrorMessage &&
          <Text style={defautStyles.errorMessage}>{valorErrorMessage}</Text>
        }
      </View>
      <TouchableOpacity style={defautStyles.loginBtn} onPress={() => onLogin()}>
        <Text style={defautStyles.loginText}>Cadastrar</Text>
      </TouchableOpacity>

      <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>{
          navigation.navigate("Login");
        }}>
          <Text style={defautStyles.loginText}>Voltar</Text>
      </TouchableOpacity>

    </View>
  )

}

const styles = StyleSheet.create({
  logo: {
    height: 100,
    width: 250
  },
});

