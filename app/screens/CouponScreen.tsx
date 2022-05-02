import React, { useEffect, useState } from 'react';
import { StyleSheet,ScrollView,SafeAreaView,FlatList,TouchableOpacity,Image } from 'react-native';

import EditScreenInfo from '../components/EditScreenInfo';
import { Text, View } from '../components/Themed';
import { urls } from '../constants/Urls';
import { useAuth } from '../hooks/authContext';
import { apiGet } from '../services/apiService';
import { getUserCoupons } from '../services/coupomService';
import {DefaultStyles} from '../styles/styles'

export default function CouponScreen({ navigation }: RootTabScreenProps<'Coupon'>) {

  const {signed,user, loading,signOut,checkAuth} = useAuth();
  const [selectedId, setSelectedId] = useState(null);
  const [isFetching, setIsFetching] = useState(false);
  const [data, setData] = useState([]);

  
  async function fetchData(){
    console.log('getCoupons');
    await getUserCoupons().
    then((result)=>{
      setData(result.data);
      console.log(data);
    })
    .catch((error)=>{
      console.log(error);

    });
  }

  useEffect(() => {
    const unsubscribe = navigation.addListener("tabPress", () => {
      checkAuth();
    });
    fetchData();
  },[]);

  const onRefresh = () => {

    checkAuth();
    setIsFetching(true);
    fetchData();

    setIsFetching(false);
  };

  const selectItem = (item) => {

/*    navigation.setOptions({
      title: `Your Updated Title`,
    })*/
    navigation.navigate('CouponDetail',{itemId:item.id});
    //console.log("Clicou...." + item.id);
  };

  
  //CouponDetailr
  const renderItem = ({ item }) => {

    return (
        <TouchableOpacity onPress={()=>selectItem(item)} style={[styles.item]} key={item.id}>
              <View style={[{
                  flexDirection: "row"
              }]} >
                <View style={{ flex: 1}}>
                  <Image source={{uri:item.partner.pictureUrl}} 
                        style={{height:50,width:50, aspectRatio:1}}
                       />
                </View>
                <View style={{ flex: 5,flexDirection:"column" }} >
                  <Text style={styles.partner}>{item.partner.name}</Text>
                  <Text style={styles.title}>{item.title}</Text>
                  <Text style={styles.description}>{item.description}</Text>
                  <Text style={styles.finishAt}>{"Válido até "}{item.finishAt}</Text>
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
        ListEmptyComponent={<EditScreenInfo path='ieouiouwe oooooo' />}
      />
  </SafeAreaView>  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor:"#fff"
  },
  title: {
    fontSize: 12,
    fontWeight: 'bold',
    marginTop:5,
    marginBottom:2
  },
  description: {
    fontSize:11,
    marginTop:2,
    marginBottom:2
  },
  finishAt: {
    fontSize:11,
    marginTop:3,
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
    marginBottom:5,
    paddingTop:10
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
