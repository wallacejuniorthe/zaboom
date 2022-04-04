import React from 'react';
import { StyleSheet,ScrollView, TouchableOpacity } from 'react-native';
import { Text, View } from '../components/Themed';
import { useAuth } from '../hooks/authContext';
import {DefaultStyles as defautStyles} from '../styles/styles'
import LabelTextInput from '../components/forms/LabetlTextInput';
import * as val from '../utils/validations';
import { changePassword} from '../services/authService';
import Validation from '../components/forms/Validation';


export default function ChangePasswordScreen({ navigation }: RootTabScreenProps<'ChangePassword'>) {

  const {user} = useAuth();

  const [errorMessage, setErrorMessage] = React.useState(null);
  const [succesMessage, setSuccesMessage] = React.useState(null);
  const [password, setPassword] = React.useState(null);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState(null);
  const [newPassword, setNewPassword] = React.useState(null);
  const [newPasswordErrorMessage, setNewPasswordErrorMessage] = React.useState(null);
  const [confirmNewPassword, setConfirmNewPassword] = React.useState(null);
  const [confirmNewPasswordErrorMessage, setconfirmNewPasswordErrorMessage] = React.useState(null);


  const onSubmit = async () => {
    
    console.log(JSON.parse(user).user.email);
    setSuccesMessage(null);
    setErrorMessage(null);
    let isFormValid = true;
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
      var result =  await changePassword(JSON.parse(user).user.id,password,newPassword);
      if(!result.success) {
        setErrorMessage(result.data);
      } else {
        setSuccesMessage("Senha alterada com sucesso");
      }
    }

  };

  return (
    <View style={defautStyles.container}>

      <Validation errorMessage={errorMessage} succesMessage={setSuccesMessage}></Validation>

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
