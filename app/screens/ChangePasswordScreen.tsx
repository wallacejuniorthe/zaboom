import React, { useEffect } from 'react';
import { StyleSheet,ScrollView, TouchableOpacity } from 'react-native';
import { Text, View } from '../components/Themed';
import { useAuth } from '../hooks/authContext';
import {DefaultStyles as defautStyles} from '../styles/styles'
import LabelTextInput from '../components/forms/LabetlTextInput';
import * as val from '../utils/validations';
import Validation from '../components/forms/Validation';
import { RootTabScreenProps } from '../types';
import { apiPost } from '../services/apiService';
import { urls } from '../constants/Urls';

export default function ChangePasswordScreen({ navigation }: RootTabScreenProps<'ChangePassword'>) {

  const {user,checkAuth} = useAuth();

  const [errorMessage, setErrorMessage] = React.useState<string | null>(null);
  const [successMessage, setSuccessMessage] = React.useState<string | null>(null);

  const [password, setPassword] = React.useState(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState(null);
  const [newPassword, setNewPassword] = React.useState(null);
  const [newPasswordErrorMessage, setNewPasswordErrorMessage] = React.useState(null);
  const [confirmNewPassword, setConfirmNewPassword] = React.useState(null);
  const [confirmNewPasswordErrorMessage, setconfirmNewPasswordErrorMessage] = React.useState(null);

  useEffect(() => {
    const unsubscribe = navigation.addListener('focus', () => {
      checkAuth();
      setPassword("123456");
      setNewPassword("123456");
      setConfirmNewPassword("123456");
    });
    return unsubscribe;
  }, [navigation]);


  const onSubmit = async () => {

    let isFormValid = true;
    setSuccessMessage(null);
    setErrorMessage(null);
    setPasswordErrorMessage(null);
    setNewPasswordErrorMessage(null);
    setconfirmNewPasswordErrorMessage(null);

    if (!val.isPasswordValid(password)) {
      setPasswordErrorMessage("Senha inválida");
      isFormValid = false;
    }

    if (!val.isPasswordValid(newPassword)) {
      setNewPasswordErrorMessage("Nova senha inválida");
      isFormValid = false;
    }

    if (!val.isPasswordValid(confirmNewPassword)) {
      setconfirmNewPasswordErrorMessage("Confirmação da senha inválida");
      isFormValid = false;
    }

    if (isFormValid) {
      const id = JSON.parse(user).user.id;
      var obj ={id,password,newPassword,confirmNewPassword};
      
      apiPost(urls.CHANGE_PASSWORD,obj)
      .then((result)=>{
        console.log("opiuopiopiopiop");
        setSuccessMessage("Senha alterada com sucesso");
      })
      .catch((result)=>{
        setErrorMessage(result.data.message);
      })
    }

  };

  return (
    <View style={defautStyles.container}>

      <Validation errorMessage={errorMessage} successMessage={successMessage}></Validation>

      <LabelTextInput placeholder="Senha atual" secureTextEntry
        setFunction={setPassword} errorMessage={passwordErrorMessage} value={password}></LabelTextInput>
     
      <LabelTextInput placeholder="Nova senha" secureTextEntry
        setFunction={setNewPassword} errorMessage={newPasswordErrorMessage} value={newPassword}></LabelTextInput>

      <LabelTextInput placeholder="Confirme a nova senha" secureTextEntry
        setFunction={setConfirmNewPassword} errorMessage={confirmNewPasswordErrorMessage} value={confirmNewPassword}></LabelTextInput>

      <TouchableOpacity style={defautStyles.loginBtn} onPress={() => onSubmit()}>
        <Text style={defautStyles.loginText}>Alterar</Text>
      </TouchableOpacity>


    </View>
  );
}

const styles = StyleSheet.create({
});
