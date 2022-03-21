/**
 * If you are not familiar with React Navigation, refer to the "Fundamentals" guide:
 * https://reactnavigation.org/docs/getting-started
 *
 */
import { FontAwesome } from '@expo/vector-icons';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer, DefaultTheme, DarkTheme } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import * as React from 'react';
import { ColorSchemeName, Pressable } from 'react-native';

import Colors from '../constants/Colors';
import useColorScheme from '../hooks/useColorScheme';
import ConfigScreen from '../screens/ConfigScreen';
import CouponActivedScreen from '../screens/CouponActivedScreen';
import CouponDetailScreen from '../screens/CouponDetailScreen';
import CouponScreen from '../screens/CouponScreen';
import ForgetPasswordScreen from '../screens/ForgetPasswordScreen';
import InfoScreen from '../screens/InfoScreen';
import LoginScreen from '../screens/LoginScreen';
import ModalScreen from '../screens/ModalScreen';
import NotFoundScreen from '../screens/NotFoundScreen';
import RegisteredScreen from '../screens/RegisteredScreen';
import RegisterScreen from '../screens/RegisterScreen';
import TabOneScreen from '../screens/TabOneScreen';
import TabThreeScreen from '../screens/TabThreeScreen';
import TabTwoScreen from '../screens/TabTwoScreen';
import { RootStackParamList, RootTabParamList, RootTabScreenProps } from '../types';
import LinkingConfiguration from './LinkingConfiguration';

export default function Navigation({ colorScheme }: { colorScheme: ColorSchemeName }) {
  return (
    <NavigationContainer
      theme={colorScheme === 'dark' ? DarkTheme : DefaultTheme}>
      <RootNavigator />
    </NavigationContainer>
  );
}

/**
 * A root stack navigator is often used for displaying modals on top of all other content.
 * https://reactnavigation.org/docs/modal
 */
const Stack = createNativeStackNavigator<RootStackParamList>();

function RootNavigator() {
  return (
    <Stack.Navigator>
      <Stack.Screen name="Login" component={LoginScreen} options={{ headerShown: false }} />
      <Stack.Screen name="ForgetPassword" component={ForgetPasswordScreen} options={{ headerShown: false}} />
      <Stack.Screen name="Register" component={RegisterScreen} options={{ headerShown: false}} />
      <Stack.Screen name="Registered" component={RegisteredScreen} options={{ headerShown: false}} />
      
      <Stack.Screen name="Root" component={BottomTabNavigator} options={{ headerShown: false }} />
      <Stack.Screen name="NotFound" component={NotFoundScreen} options={{ title: 'Oops!' }} />
      <Stack.Group screenOptions={{ presentation: 'modal' }}>
        <Stack.Screen name="Modal" component={ModalScreen} />
      </Stack.Group>
      <Stack.Screen name="Info" component={InfoScreen} options={{ title: 'Oops!' }} />
      <Stack.Screen name="CouponDetail" component={CouponDetailScreen} options={{ title: 'Oops!' }} />
    </Stack.Navigator>
  );
}

/**
 * A bottom tab navigator displays tab buttons on the bottom of the display to switch screens.
 * https://reactnavigation.org/docs/bottom-tab-navigator
 */
const BottomTab = createBottomTabNavigator<RootTabParamList>();

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
        name="Config"
        component={ConfigScreen}
        options={{
          title: 'Configurações',
          tabBarIcon: ({ color }) => <TabBarIcon name="adjust" color={color} />,
          headerShown: false
        }}
      />

      <BottomTab.Screen
        name="TabOne"
        component={TabOneScreen}
        options={({ navigation }: RootTabScreenProps<'TabOne'>) => ({
          title: 'Tab Oneuu',
          tabBarIcon: ({ color }) => <TabBarIcon name="user" color={color} />,
          headerRight: () => (
            <Pressable
              onPress={() => navigation.navigate('Modal')}
              style={({ pressed }) => ({
                opacity: pressed ? 0.5 : 1,
              })}>
              <FontAwesome
                name="info-circle"
                size={25}
                color={Colors[colorScheme].text}
                style={{ marginRight: 15 }}
              />
            </Pressable>
          ),
        })}
      />
      <BottomTab.Screen
        name="TabThree"
        component={TabThreeScreen}
        options={{
          title: 'Meus cupons',
          tabBarIcon: ({ color }) => <TabBarIcon name="code" color={color} />,
        }}
      />

    </BottomTab.Navigator>
  );
}

/**
 * You can explore the built-in icon families and icons on the web at https://icons.expo.fyi/
 */
function TabBarIcon(props: {
  name: React.ComponentProps<typeof FontAwesome>['name'];
  color: string;
}) {
  return <FontAwesome size={30} style={{ marginBottom: -3 }} {...props} />;
}
