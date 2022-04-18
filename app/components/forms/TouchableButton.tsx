import React, { Component, useEffect, useState } from 'react';
import { StyleSheet,TextInput,View,Text, TouchableOpacity, ActivityIndicator } from 'react-native';
import {DefaultStyles as defautStyles} from '../../styles/styles'

export default function TouchableButton(props){

  return(

    <TouchableOpacity disabled={props.isLoading || props.disabledButton} {...props}
    >

    <View >
      {props.isLoading && <ActivityIndicator size="small" color="yellow" />}
      <Text style={props.TextStyle}>
        {props.isLoading ? "Processando" : props.Text}
      </Text>
    </View>

    </TouchableOpacity>
  
)

}

const styles = StyleSheet.create({
});

