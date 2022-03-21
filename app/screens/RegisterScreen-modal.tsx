import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TouchableOpacity,Image, Pressable, Modal, FlatList } from 'react-native';
import { Text, View,TextInput } from '../components/Themed';
import { RootTabScreenProps,StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import {AuthService} from '../services/authService';
import * as val from '../utils/validations';
import RNPickerSelect, { defaultStyles } from 'react-native-picker-select';
import {sports} from '../data/data'

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

  const items = [
    //name key is must.It is to show the text in front
    { id: 1, name: 'angellist' },
    { id: 2, name: 'codepen' },
    { id: 3, name: 'envelope' },
    { id: 4, name: 'etsy' },
    { id: 5, name: 'facebook' },
    { id: 6, name: 'foursquare' },
    { id: 7, name: 'github-alt' },
    { id: 8, name: 'github' },
    { id: 9, name: 'gitlab' },
    { id: 10, name: 'instagram' },
    { id: 11, name: 'instagram' },
    { id: 12, name: 'instagram' },
    { id: 13, name: 'instagram' },
    { id: 14, name: 'instagram' },
    { id: 15, name: 'instagram' },
    { id: 16, name: 'instagram' },
    { id: 17, name: 'instagram' },
    { id: 18, name: 'instagram' },
    { id: 19, name: 'instagram' },
    { id: 20, name: 'instagram' },
    { id: 21, name: 'instagram' },
    { id: 22, name: 'instagram' },
    { id: 23, name: 'instagram' },
    { id: 24, name: 'instagram' },
  ];
  

  const onLogin = ()=>{

    let isFormValid = true;
    setNameErrorMessage(null);
    setEmailErrorMessage(null);
    setPasswordErrorMessage(null);
    setConfirmPasswordErrorMessage(null);
    setValorErrorMessage(null);

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

    if(!valor) {
      setValorErrorMessage("Selecione o condomínio");
      isFormValid = false;
    }


    
    if(isFormValid){
      var obj = {
        email:email,
        password:password,
        name:name,
        confirmPassword:confirmPassword,
        valor:valor
      };
      console.log(obj);
    }
  };

  const renderItem = ({ item }) => {
    return (
        <TouchableOpacity onPress={()=>console.log('poiio')} key={item.id}>
          <View style={[{
                  flexDirection: "row"
              }]} >
                <View >
                  <Text>{item.id} {item.name}</Text>
                </View>
          </View>
        </TouchableOpacity>
    );
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

        <Modal
        animationType="slide"
        transparent={true}
        visible={modalVisible}
        onRequestClose={() => {
          console.log('111111');
          setModalVisible(!modalVisible);
        }}
      >
        <View style={styles.centeredView}>
          <View style={styles.modalView}>
          <FlatList
              data={items}
              renderItem={renderItem}
              keyExtractor={item => item.id}
          />
            <Pressable
              style={[styles.button, styles.buttonClose]}
              onPress={() => setModalVisible(!modalVisible)}
            >
              <Text style={styles.textStyle}>Hide Modal</Text>
            </Pressable>
          </View>
        </View>
      </Modal>
      <Pressable
        style={[styles.button, styles.buttonOpen]}
        onPress={() => setModalVisible(true)}
      >
        <Text style={styles.textStyle}>Show Modal</Text>
      </Pressable>
      <View style={defautStyles.inputView} >

          <RNPickerSelect
            placeholder={{}}
            items={sports}
            onValueChange={value => {
              setValor(value);
              console.log(value);
            }}
            InputAccessoryView={() => null}
            style={styles}
            value={valor}
          />
      </View>
      { valorErrorMessage && 
            <Text style={defautStyles.errorMessage}>{valorErrorMessage}</Text>
        }

      </View>
  )

}

const styles = StyleSheet.create({
  logo:{
    height:100,
    width:250
  },
  centeredView: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    marginTop: 22
  },
  modalView: {
    margin: 20,
    backgroundColor: "white",
    borderRadius: 20,
    padding: 35,
    alignItems: "center",
    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 2
    },
    shadowOpacity: 0.25,
    shadowRadius: 4,
    elevation: 5
  },
  button: {
    borderRadius: 20,
    padding: 10,
    elevation: 2
  },
  buttonOpen: {
    backgroundColor: "#F194FF",
  },
  buttonClose: {
    backgroundColor: "#2196F3",
  },
  textStyle: {
    color: "white",
    fontWeight: "bold",
    textAlign: "center"
  },
  modalText: {
    marginBottom: 15,
    textAlign: "center"
  },
  inputIOS: {
    fontSize: 16,
    paddingVertical: 12,
    paddingHorizontal: 10,
    borderWidth: 1,
    borderColor: 'gray',
    borderRadius: 4,
    color: 'black',
    paddingRight: 30, // to ensure the text is never behind the icon
  },
  inputAndroid: {
    fontSize: 16,
    paddingHorizontal: 10,
    paddingVertical: 8,
    borderWidth: 0.5,
    borderColor: 'purple',
    borderRadius: 8,
    color: 'black',
    paddingRight: 30, // to ensure the text is never behind the icon
  }
});

