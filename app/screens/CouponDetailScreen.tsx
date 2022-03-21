import React, { useEffect, useState } from 'react';
import { Button, StyleSheet } from 'react-native';
import { Text, View } from '../components/Themed';

export default function CouponDetailScreen({ route, navigation }) {

  const [selectedId, setSelectedId] = useState(null);
  const { item } = route.params;

  useEffect(() => {
    navigation.setOptions({
      title: item.partner,
    });
  });

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Parceiro</Text>
      <Text style={styles.title}>Cacique Pneus</Text>
      <Text style={styles.title}>Cumpon</Text>
      <Text style={styles.title}>r eurwioruewr</Text>
      <Text style={styles.title}>Regras de utilização</Text>
      <Text style={styles.title}>{item.id}</Text>
      <Text style={styles.title}>Detalhes cupon {item.id}</Text>
      <View style={styles.separator} lightColor="#eee" darkColor="rgba(255,255,255,0.1)" />
      <Button
  title="Learn More"
  color="#841584"
  accessibilityLabel="Learn more about this purple button"
/>
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
