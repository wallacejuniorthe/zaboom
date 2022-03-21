import React from 'react';
import { StyleSheet,ScrollView } from 'react-native';
import { Text, View } from '../components/Themed';
import { RootTabScreenProps } from '../types';

export default function ConfigScreen({ navigation }: RootTabScreenProps<'Config'>) {
  return (
    <ScrollView>
      <View style={styles.container}>
      </View>
    </ScrollView>

  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
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
