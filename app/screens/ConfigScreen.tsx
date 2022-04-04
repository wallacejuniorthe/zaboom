import React from 'react';
import { StyleSheet,ScrollView, TouchableOpacity } from 'react-native';
import { Text, View } from '../components/Themed';
import { useAuth } from '../hooks/authContext';
import { RootTabScreenProps } from '../types';

export default function ConfigScreen({ navigation }: RootTabScreenProps<'Config'>) {

  const onChangePassword = ()=>{
    navigation.navigate('ChangePassword');
  };

  const {user, loading,signOut} = useAuth();
  console.log(user);
  return (
    <View style={styles.container}>
      <TouchableOpacity onPress={()=>onChangePassword()}  key={0}  style={styles.item} > 
        <View style={styles.itemView}>
          <Text style={styles.itemText}>Alterar senha</Text>
        </View>
      </TouchableOpacity>
      <TouchableOpacity onPress={()=>signOut()}  key={1}  style={styles.item} > 
        <View style={styles.itemView}>
          <Text style={styles.itemText}>Sair</Text>
        </View>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    marginBottom:20
  },
  item: {
    width:'95%',
    borderBottomWidth:1,
    borderBottomColor:'#c1c1c1'
  },
  itemView: {
    height:70,
    justifyContent:'center'
  },
  itemText: {
    color:'#000'
  },
  title: {
    fontSize: 20,
    fontWeight: 'bold',
  },
  separator: {
    marginVertical: 30,
    height: 1,
    width: '80%',
  },
});
