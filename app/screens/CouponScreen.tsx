import React, { useEffect, useState } from 'react';
import { StyleSheet,ScrollView,SafeAreaView,FlatList,TouchableOpacity,Image } from 'react-native';

import EditScreenInfo from '../components/EditScreenInfo';
import { Text, View } from '../components/Themed';
import {data} from '../data/data.js';
import { useAuth } from '../hooks/authContext';
import { apiGet } from '../services/apiService';
import { ApiResponse } from '../types';

export default function CouponScreen({ navigation }: RootTabScreenProps<'Coupon'>) {

  const {signed,user, loading,signOut,incrementCounter,checkAuth} = useAuth();
  const [selectedId, setSelectedId] = useState(null);
  const [isFetching, setIsFetching] = useState(false);


  useEffect(() => {
    const unsubscribe = navigation.addListener("tabPress", () => {
      checkAuth();
      console.log('1');
    });
    console.log('12');

    });

  const onRefresh = () => {
    //setIsFetching(true);
    checkAuth();

    apiGet('http://192.168.100.66:8080/teste/hello')
    .then((res1)=>{
      console.log(res1.data);
    }).catch((error)=>{
      //console.log(error);
    });

    //setIsFetching(false);
  };

  const selectItem = (item) => {
    navigation.setOptions({
      title: `Your Updated Title`,
    })
    navigation.navigate('CouponDetail',{itemId:item.id});
    console.log("Clicou...." + item.id);
  };

  
  //CouponDetailr
  const renderItem = ({ item }) => {

    return (
        <TouchableOpacity onPress={()=>selectItem(item)} style={[styles.item]} key={item.id}>
              <View style={[{
                  flexDirection: "row"
              }]} >
                <View style={{ flex: 1}}>
                  <Image source={require('../assets/images/americanas.png')} 
                        style={{height:50,width:50, aspectRatio:1}}
                       />
                </View>
                <View style={{ flex: 5,flexDirection:"column" }} >
                  <Text style={styles.partner}>{item.id} {item.partner}</Text>
                  <Text style={styles.description}>{item.description}</Text>
                  <Text style={styles.detail}>{item.title}</Text>
                </View>
          </View>
        </TouchableOpacity>
    );
  };

  return (
    <SafeAreaView style={styles.container}>
      <FlatList
        data={data}
        renderItem={renderItem}
        keyExtractor={(item) => item.id}
        extraData={selectedId}
        onEndReached={()=>console.log("Chegou aom fim")}
        refreshing={isFetching}
        onRefresh={onRefresh}
        ListEmptyComponent={<EditScreenInfo path='ieouiouwe' />}
      />
  </SafeAreaView>  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    marginTop:80,
    backgroundColor:"#fff"
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
  item:{
    color:'#000',
    padding:5,
    borderBottomColor:'#f1f1f1',
    borderBottomWidth:1,
    marginBottom:5
  },
  stretch: {
    width: 50,
  },
  imageView: {
    flex:2,
    height:150

  },
  itemView: {
    flex:7
  },
  partner: {
    fontWeight:"bold",
    fontSize:12,
    marginBottom:2
  },
  description: {
    fontSize:11
   
  },
  detail: {
    fontSize:10,
    color:"#f1f1f1"
  }
 
});
