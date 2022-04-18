import React, { useEffect, useState } from 'react';
import { StyleSheet, Button, TouchableOpacity, Image, Pressable, Modal, FlatList } from 'react-native';
import { Text, View, TextInput } from '../components/Themed';
import { RootTabScreenProps, StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import { DefaultStyles as defautStyles } from '../styles/styles'
import colors from '../constants/Colors'
import { validateAccount, resendVerificationToken } from '../services/authService';
import * as val from '../utils/validations';
import RNPickerSelect, { defaultStyles } from 'react-native-picker-select';
import { sports } from '../data/data'
import LabelTextInput from '../components/forms/LabetlTextInput';
import Validation from '../components/forms/Validation';
import TouchableButton from '../components/forms/TouchableButton';

export default function RegisteredScreen({ route, navigation }: RootTabScreenProps<'Registered'>) {

  const [code, setCode] = React.useState<string | null>(null);
  const [codeErrorMessage, setCodeErrorMessage] = React.useState<string | null>(null);
  const [errorMessage, setErrorMessage] = React.useState<string | null>(null);
  const [successMessage, setSuccessMessage] = React.useState<string | null>(null);
  const [alertMessage, setAlertMessage] = React.useState<string | null>(null);
  const [isLoading, setLoading] = React.useState<boolean | null>(null);
  const [isLoadingNewCode, setLoadingNewCode] = React.useState<boolean | null>(null);
  const [newCodeButtonDisabled, setNewCodeButtonDisabled] = React.useState<boolean | null>(null);

  const { id, name, email } = route.params;

  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
    });
    return unsubscribe;
  }, [navigation]);


  const onLogin = async () => {

    setLoading(true);

    let isFormValid = true;
    setCodeErrorMessage(null);
    setErrorMessage(null);
    setSuccessMessage(null);
    setAlertMessage(null)

    if (val.isEmpty(code)) {
      setCodeErrorMessage("Informe o código recebido");
      isFormValid = false;
    }
    if (isFormValid) {
      validateAccount(id as number, code as string)
        .then((result) => {
          navigation.navigate("Login", {
            successMessageParam: result.data.message
          });
        }).catch((result) => {
          console.log(result);
          setErrorMessage(result.data.message);
        })
        .finally(() => {
        });
    }
    setLoading(false);
  };

  const onResendToken = async () => {

    let isFormValid = true;
    setErrorMessage(null);
    setSuccessMessage(null);
    setAlertMessage(null)

    setLoadingNewCode(true);
    setNewCodeButtonDisabled(true);

    if (isFormValid) {
      resendVerificationToken(id as number)
        .then((result) => {
          setSuccessMessage(result.data.message);
        }).catch((result) => {
          setErrorMessage(result.data.message);
        })
        .finally(() => {
          setLoadingNewCode(false);
          setTimeout(()=>{
            setNewCodeButtonDisabled(false);
          },60000)
        });
    }
  };

  return (

    <View style={defautStyles.container}>

      <Image source={require('../assets/images/logo.png')} style={styles.logo} />

      <View>
        <Text>Seja bem-vindo(a), ${name}. Para validar seu cadastro informe o código recebido via SMS/Email</Text>
      </View>

      <Validation errorMessage={errorMessage} successMessage={successMessage} alertMessage={alertMessage}></Validation>


      <LabelTextInput placeholder="Cógido"
        setFunction={setCode} errorMessage={codeErrorMessage} value={code}></LabelTextInput>


      <TouchableButton isLoading={isLoading}  style={defautStyles.loginBtn}
      onPress={() => onLogin()}
        Text="Validar" TextStyle={defautStyles.loginText}
      ></TouchableButton>


      <TouchableButton isLoading={isLoadingNewCode}  style={newCodeButtonDisabled?defautStyles.disableBtn:defautStyles.loginBtn} onPress={() => onResendToken()}
        Text="Reenviar código" TextStyle={defautStyles.loginText}
        disabledButton={newCodeButtonDisabled}
      ></TouchableButton>



    </View>
  )

}

const styles = StyleSheet.create({
  logo: {
    height: 100,
    width: 250
  },
});

