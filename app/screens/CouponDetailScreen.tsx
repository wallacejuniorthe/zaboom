import React, { useEffect, useState } from 'react';
import { ActivityIndicator, Button, StyleSheet, Image, TouchableOpacity } from 'react-native';
import { Text, View } from '../components/Themed';
import { getCouponDetail,activateCoupon } from '../services/coupomService';
import { DefaultStyles as defautStyles } from '../styles/styles'
import QRCode from 'react-native-qrcode-svg';


export default function CouponDetailScreen({ route, navigation }) {

  const [isFetching, setIsFetching] = useState(false);
  const [data2, setData2] = React.useState<object | null>({});
  const [code, setCode] = React.useState<string | null>(null);

  const { itemId } = route.params;
  var teste = "iouuiuiuio1111";

  
  useEffect(() => {
//    console.log(itemId);
/*    navigation.setOptions({
      title: itemId
    });*/
    setIsFetching(true);

    const fetchData = async () => {
      const result = await getCouponDetail(itemId);
      setData2(JSON.parse(JSON.stringify(result.data)));
      setCode(result.data.code)
      console.log(data2);
      setIsFetching(false);
    }
    fetchData();
  },[]);

  const onActivate = async () => {
    try{
      const result =  await activateCoupon(itemId);
    } catch(error){

    }
  };

  
  if (isFetching) {
    return (
      <View style={{flex: 1, justifyContent: 'center', alignItems: 'center'}}>
        <ActivityIndicator size="large" color="#666"  />
      </View>
    );
  }

  return (
    <View style={styles.container}>

      <Text style={styles.title}>{data2.title}</Text>
      <Text style={styles.title}>{data2.description}</Text>
      <Text style={styles.title}>{data2.finishAt}</Text>
      <View style={styles.separator} lightColor="#eee" darkColor="rgba(255,255,255,0.1)" />
      <Text style={styles.title}>{data2.regulation}</Text>
      <View style={styles.separator} lightColor="#eee" darkColor="rgba(255,255,255,0.1)" />
      {code &&
        <View>
              <QRCode 
            value={code ? code : 'NA'} 
            size={250} 
            color="black" 
            backgroundColor="white" 
            logoSize={30} 
            logoMargin={2} 
            logoBorderRadius={15} 
            logoBackgroundColor="yellow" 
          /> 
        </View>
      }
      <View>
        <TouchableOpacity style={defautStyles.loginRegister} onPress={() => onActivate()}>
          <Text style={defautStyles.loginText}>Ativar cupom</Text>
        </TouchableOpacity>
      </View>


    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
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
