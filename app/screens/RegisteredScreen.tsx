import React, { useEffect, useState } from 'react';
import { StyleSheet, Button, TouchableOpacity, Image, Pressable, Modal, FlatList } from 'react-native';
import { Text, View, TextInput } from '../components/Themed';
import { RootTabScreenProps, StorageKey } from '../types';
import * as SecureStore from 'expo-secure-store';
import { DefaultStyles as defautStyles } from '../styles/styles'
import colors from '../constants/Colors'
import { AuthService } from '../services/authService';
import * as val from '../utils/validations';
import RNPickerSelect, { defaultStyles } from 'react-native-picker-select';
import { sports } from '../data/data'
import LabelTextInput from '../components/forms/LabetlTextInput';

export default function RegisteredScreen({ route,navigation }: RootTabScreenProps<'Registered'>) {

  const { name,email } = route.params;


  useEffect(() => {
  });
  

  return (

    <View style={defautStyles.container}>

      <Image source={require('../assets/images/logo.png')} style={styles.logo} />

      <View>
        <Text>Seja bem-vindo(a), ${name}. Foi encaminhado um email para endereço ${email}. Acesse se</Text>
      </View>

      <TouchableOpacity style={defautStyles.loginBtn} onPress={()=>{
          navigation.navigate("Login");
        }}>
          <Text style={defautStyles.loginText}>Acessar o sistema</Text>
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

