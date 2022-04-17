import React, { Component, useEffect, useState } from 'react';
import { StyleSheet,TextInput,View,Text } from 'react-native';
import {DefaultStyles as defautStyles} from '../../styles/styles'

export default function Validation(props){

  const errorMessage = props.errorMessage;
  const successMessage = props.successMessage;
  const alertMessage = props.alertMessage;
  
  return(
    <View  style={defautStyles.validationMessageView}> 
      {errorMessage &&
      <View style={[defautStyles.validationTextMessageView,defautStyles.validationErrorTextMessageView]}>
            <Text style={defautStyles.errorTextMessage}>{errorMessage}</Text>
        </View>
      }
      {successMessage &&
      <View style={[defautStyles.validationTextMessageView,defautStyles.validationSuccessTextMessageView]}>
            <Text style={defautStyles.successTextMessage}>{successMessage}</Text>
        </View>
      }
      {alertMessage &&
      <View style={[defautStyles.validationTextMessageView,defautStyles.validationAlertTextMessageView]}>
            <Text style={defautStyles.alertTextMessage}>{alertMessage}</Text>
        </View>
      }
    </View>

  )

}

const styles = StyleSheet.create({
});

