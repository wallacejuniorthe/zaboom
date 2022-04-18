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
import Validation from '../components/forms/Validation';

export default function RegisterScreen({ navigation }: RootTabScreenProps<'Register'>) {

  const [modalVisible, setModalVisible] = useState(false);

  const [errorMessage, setErrorMessage] = React.useState<string | null>(null);

  const [name, setName] = React.useState<string | null>(null);
  const [nameErrorMessage, setNameErrorMessage] = React.useState<string | null>(null);
  const [email, setEmail] = React.useState<string | null>(null);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState<string | null>(null);
  const [phone, setPhone] = React.useState<string | null>(null);
  const [phoneErrorMessage, setPhoneErrorMessage] = React.useState<string | null>(null);
  const [password, setPassword] = React.useState<string | null>(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState<string | null>(null);
  const [confirmPassword, setConfirmPassword] = React.useState<string | null>(null);
  const [confirmPasswordErrorMessage, setConfirmPasswordErrorMessage] = React.useState<string | null>(null);

  const [local, setLocal] = React.useState<string | null>(null);
  const [localErrorMessage, setLocalErrorMessage] = React.useState<string | null>(null);


  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      setName("Wallace Junior");
      setEmail("teste@teste.com");
      setPhone("(86)994043202");
      setPassword("123456");
      setConfirmPassword("123456");
    });
    return unsubscribe;
  }, [navigation]);
  
  const onLogin = async () => {

    let isFormValid = true;
    setNameErrorMessage(null);
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setPhoneErrorMessage(null)
    setConfirmPasswordErrorMessage(null);
    setLocalErrorMessage(null);

    if (val.isEmpty(name)) {
      setNameErrorMessage("Informe seu nome");
      isFormValid = false;
    }

    if (!val.isEmail(email, true)) {
      setEmailErrorMessage("Informe um email válido");
      isFormValid = false;
    }

    if (val.isEmpty(phone)) {
      setPhoneErrorMessage("Informe um número de celular válido");
      isFormValid = false;
    }

    if (!val.isPasswordValid(password)) {
      setPasswordErrorMessage("Informe sua senha (6 a 12 caracteres)");
      isFormValid = false;
    }

    if (!val.isPasswordValid(confirmPassword)) {
      setConfirmPasswordErrorMessage("Confirme sua senha");
      isFormValid = false;
    }

    if (password!==confirmPassword) {
      setConfirmPasswordErrorMessage("Senhas informadas não coincidem");
      isFormValid = false;
    }

    if (val.isEmpty(local, true)) {
      setLocalErrorMessage("Selecione o local que mora");
      isFormValid = false;
    }

    if (isFormValid) {
      console.log('iiiiioo');
      registerUser(name as string,email  as string,phone as string,password  as string,confirmPassword  as string)
      .then((result)=>{
        navigation.navigate("Registered",{ id:result.data.id, name:result.data.name});
      })
      .catch((result)=>{
        setErrorMessage(result.data.message);
      });
    }
  };

  return (

    <View style={defautStyles.container}>

      <Image source={require('../assets/images/logo.png')} style={styles.logo} />

      <Validation errorMessage={errorMessage} ></Validation>

      <LabelTextInput placeholder="Nome" 
        setFunction={setName} errorMessage={nameErrorMessage} value={name}></LabelTextInput>

      <LabelTextInput placeholder="Email" 
        setFunction={setEmail} errorMessage={emailErrorMessage} value={email}></LabelTextInput>
      
      <LabelTextInput placeholder="Celular" 
        setFunction={setPhone} errorMessage={phoneErrorMessage} value={phone}></LabelTextInput>
      
      <LabelTextInput placeholder="Senha (6 a 12 caracteres)" secureTextEntry
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password}></LabelTextInput>

      <LabelTextInput placeholder="Senha" secureTextEntry
        setFunction={setConfirmPassword} errorMessage={confirmPasswordErrorMessage} value={confirmPassword}></LabelTextInput>
  
      <View style={defautStyles.formField}>
        <View style={defautStyles.inputView} >
          <RNPickerSelect
            placeholder={{label:"Selecione o local que você mora"}}
            items={sports}
            onValueChange={value => {
              setLocal(value);
            }}
            InputAccessoryView={() => null}
            style={defautStyles.pickerSelect}
            value={local}
          />
        </View>
        {localErrorMessage &&
          <Text style={defautStyles.errorMessage}>{localErrorMessage}</Text>
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

