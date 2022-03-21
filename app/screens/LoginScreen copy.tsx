import React, { useEffect, useState } from 'react';
import { StyleSheet,Button,TextInput,TouchableOpacity,Image } from 'react-native';
import { Text, View } from '../components/Themed';
import { RootTabScreenProps,StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import {DefaultStyles as defautStyles} from '../styles/styles'
import colors from '../constants/Colors'
import MyTextInput from '../components/forms/MyTextInput';
import {AuthService} from '../services/authService';

export default function LoginScreenXXX({ navigation }: RootTabScreenProps<'Login'>) {
  
/*  useEffect(()=>{
    SecureStore.getItemAsync(StorageKey)
    .then(()=>{
      console.log('Logado....');
    })
  });
  */
  var Validation1 = (value)=>{
    return "";
  }


  const formDefinition ={
    fields:{
      "email":{
        type:"string",
        value:null,
        validations:[{
            type:"required",
            errorMessage:'Email inválido',
            isValid:null
          },{
            type:"custom",
            errorMessage:'Email inválido',
            validationFunction: 'Validation1',
            isValid:null
          }]
      }
    },
    valid:null
  }

  const [email, onChangeEmail] = React.useState(null);
  const [validEmail, isValidEmail] = React.useState();
  const [form, setForm] = React.useState(formDefinition);
  

  const setFormFieldState = (name:string,value:any) => {
    let formTemp = form;
    let fieldTemp = formTemp.fields[name];
    fieldTemp.value = value;

    for(var i in fieldTemp.validations) {
      var validation = fieldTemp.validations[i];
      validation.isValid = true;
      if(validation.type=="required" && (value==null || value=='undefined' || value=='') ){
        validation.isValid = false;
      } 
      else if(validation.type==="custom"){
        let mensagemErroFunction="";
        eval("mensagemErroFunction="+validation.validationFunction+"('"+value+"')");
//        console.log(mensagemErroFunction);
        if(mensagemErroFunction)
          validation.isValid = false;
      }
   }

   formTemp.fields[name] = fieldTemp;
   setForm(formTemp);
//   console.log(form);

  }

  const onLogin = ()=>{
    
    const authService = new AuthService();
    //let s = users.filter(x=>x.email=='u11@teste.com' && x.password=='123456');
    //console.log('filtro...',s.length);

//    console.log(authService.authenticateUser('uiouio','iuiouio'));


    var isValid = true; 
    //console.log(form.fields);
    for(var i in form.fields) {
      const field = form.fields[i];
      for(var j in form.fields[i].validations)
      {
        const validation = form.fields[i].validations[j];
        if(!validation.isValid)
        {
          isValid=false;
        }
      }
    }
  //  console.log(isValid);
      
  };

  return(
    <View style={defautStyles.container}>
        <Image source={require('../assets/images/logo.png')} style={styles.logo}/>

        <MyTextInput />
        
        <View style={defautStyles.inputView} >
          <TextInput  
            style={defautStyles.inputText}
            placeholder="Email" 
            placeholderTextColor={colors.placeholderTextColor}
            onChangeText={value => setFormFieldState('email',value)}
            />
            <Text>{form.fields.email.value}</Text>

        </View>
        <View style={defautStyles.inputView} >
          <TextInput  
            secureTextEntry
            style={defautStyles.inputText}
            placeholder="Senha" 
            placeholderTextColor={colors.placeholderTextColor}
            />
        </View>
        <TouchableOpacity>
          <Text style={defautStyles.forgot}>Esqueceu sua senha?</Text>
        </TouchableOpacity>
        <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>onLogin()}>
          <Text style={defautStyles.loginText}>Entrar</Text>
        </TouchableOpacity>
        <TouchableOpacity>
          <Text style={defautStyles.loginText}>Faça seu cadastro</Text>
        </TouchableOpacity>
      </View>
  )

}

const styles = StyleSheet.create({
  logo:{
    height:100,
    width:250,
    marginBottom:30
  }
});

