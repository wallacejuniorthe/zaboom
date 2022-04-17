import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import TabOneScreen from '../screens/TabOneScreen';
import useColorScheme from '../hooks/useColorScheme';
import Colors from '../constants/Colors';
import { FontAwesome } from '@expo/vector-icons';
import React from 'react';
import { Pressable } from 'react-native';
import ConfigScreen from '../screens/ConfigScreen';
import CouponActivedScreen from '../screens/CouponActivedScreen';
import CouponScreen from '../screens/CouponScreen';
import TabThreeScreen from '../screens/TabThreeScreen';
import { RootTabScreenProps } from '../types';
import ChangePasswordScreen from '../screens/ChangePasswordScreen';
import CouponDetailScreen from '../screens/CouponDetailScreen';

const BottomTab = createBottomTabNavigator();

function BottomTabNavigator() {
  const colorScheme = useColorScheme();

  return (
    <BottomTab.Navigator
      initialRouteName="Coupon"
      screenOptions={{
        tabBarActiveTintColor: Colors[colorScheme].tint,
      }}>
      <BottomTab.Screen
        name="Coupon"
        component={CouponScreen}
        options={{
          title: 'Meus cupons',
          tabBarIcon: ({ color }) => <TabBarIcon name="code" color={color} />,
          headerShown: false
        }} 
      />
      <BottomTab.Screen
        name="CouponActived"
        component={CouponActivedScreen}
        options={{
          title: 'Cupons ativados',
          tabBarIcon: ({ color }) => <TabBarIcon name="adjust" color={color} />,
          headerShown: false
        }}
      />
      <BottomTab.Screen
        name="TabThree"
        component={TabThreeScreen}
        options={{
          title: 'Meus cupons',
          tabBarIcon: ({ color }) => <TabBarIcon name="code" color={color} />,
        }}
      />
      <BottomTab.Screen
        name="Config"
        component={ConfigScreen}
        options={{
          title: 'Perfil',
          tabBarIcon: ({ color }) => <TabBarIcon name="adjust" color={color} />,
          unmountOnBlur:true
          
        }}
      />

    </BottomTab.Navigator>
  );
}

function TabBarIcon(props: {
  name: React.ComponentProps<typeof FontAwesome>['name'];
  color: string;
}) {
  return <FontAwesome size={30} style={{ marginBottom: -3 }} {...props} />;
}



const AppStack = createNativeStackNavigator();

const AppRoutes = () => (
  <AppStack.Navigator >
    <AppStack.Screen name="Root" component={BottomTabNavigator}  options={{ headerShown: false}} />
    <AppStack.Screen name="ChangePassword" component={ChangePasswordScreen}  options={{ title:"Alterar senha"}}  />
    <AppStack.Screen name="CouponDetail" component={CouponDetailScreen}  options={{ title:"Cupom XX"}}  />
  </AppStack.Navigator>
);

export default AppRoutes;