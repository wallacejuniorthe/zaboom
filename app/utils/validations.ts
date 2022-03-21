

export function isEmpty(value:string) {
    return value && value.length>0?false:true;
} 

export function isEmail(value:string,required:boolean) {
    
    if(required && isEmpty(value))
        return false;

    return value.match(
        /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
        );
} 

export function isPasswordValid(value:string,minSize:number,maxSize:number,required:boolean) {
    
    if(required && isEmpty(value))
        return false;
    value = value.trim();
    return value.length>=minSize && value.length<=maxSize;
} 