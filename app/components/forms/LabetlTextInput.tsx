import React, { Component, useEffect, useState } from 'react';
import { StyleSheet,TextInput,View,Text } from 'react-native';
import {DefaultStyles as defautStyles} from '../../styles/styles'
import colors from '../../constants/Colors'
import { TextInputProps } from 'react-native';

export default function LabelTextInput(props){

  return(
    <View style={defautStyles.formField}>
      <View style={defautStyles.inputView} >
        <TextInput  
          style={defautStyles.inputText}
          placeholderTextColor={colors.placeholderTextColor}
          value={props.value}
          onChangeText={(value) => {
            props.setFunction(value);
          }}
          {...props} 
          />
      </View>
      <View>
          { props.errorMessage && 
            <Text style={defautStyles.errorMessage}>{props.errorMessage}</Text>
          }
      </View>
    </View>
  
)

}

const styles = StyleSheet.create({
});

