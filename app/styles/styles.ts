import { StyleSheet } from 'react-native';
import { Dimensions } from 'react-native';


const elementsSize:string = "80%";


export const DefaultStyles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#003f5c',
      //      backgroundColor: '#fff5d9',
      alignItems: 'center',
      justifyContent: 'center',
    },
    logo:{
      height:100,
      width:250
    },
    errorMessageView:{
      marginTop:3,
      borderColor:'red',
      borderWidth:0.5,
      width: elementsSize,
      padding:10,
      borderRadius:25,
      backgroundColor:'white'
    },
    errorMessage:{
        marginTop:3,
        color:'red',
        paddingLeft:10,
        textAlign:'left'
    },
    formField:{
      width: elementsSize,
    },
    inputView:{
      width: "100%",
      backgroundColor:"#465881",
      borderRadius:25,
      height:50,
      marginTop:10,
      justifyContent:"center",
      padding:20,
      borderWidth:1,
      borderColor:'#fdfdfd',
    },
    inputText:{
      height:50,
      color:"#000",
      backgroundColor:"#465881",
      borderTopWidth:1,
      borderBottomWidth:1,
      borderColor:'#fdfdfd',
    },
    forgot:{
      color:"white",
      fontSize:13
    },
    loginBtn:{
      width:"80%",
      backgroundColor:"#fb5b5a",
      borderRadius:25,
      height:50,
      alignItems:"center",
      justifyContent:"center",
      marginTop:40,
      marginBottom:10
    },
    loginRegister:{
      width:"80%",
      backgroundColor:"#32a852",
      borderRadius:25,
      height:50,
      alignItems:"center",
      justifyContent:"center",
      marginTop:40,
      marginBottom:10
    },
    loginText:{
      color:"white"
    },
      textErrorMessage:{
        color:'#000'
      },
      inputIOS: {
        fontSize: 16,
        paddingVertical: 12,
        paddingHorizontal: 10,
        borderWidth: 1,
        borderColor: 'gray',
        borderRadius: 4,
        color: 'black',
        paddingRight: 30, // to ensure the text is never behind the icon
      },
      inputAndroid: {
        fontSize: 16,
        paddingHorizontal: 10,
        paddingVertical: 8,
        borderWidth: 0.5,
        borderColor: 'purple',
        borderRadius: 8,
        color: 'black',
        paddingRight: 30, // to ensure the text is never behind the icon
      },
      centeredView: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
        marginTop: 22
      },
      modalView: {
        margin: 20,
        backgroundColor: "white",
        borderRadius: 20,
        padding: 35,
        alignItems: "center",
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2
        },
        shadowOpacity: 0.25,
        shadowRadius: 4,
        elevation: 5
      },
      button: {
        borderRadius: 20,
        padding: 10,
        elevation: 2
      },
      buttonOpen: {
        backgroundColor: "#F194FF",
      },
      buttonClose: {
        backgroundColor: "#2196F3",
      },
      textStyle: {
        color: "white",
        fontWeight: "bold",
        textAlign: "center"
      },
      modalText: {
        marginBottom: 15,
        textAlign: "center"
      }
    
    
  });
  
  
