#include<stdio.h>

int main(){

int num1=10;
int num2=5;

if(num1>num2){
    printf("%d is greater than %d",num1,num2);
}
else if(num1<num2){
    printf("%d is greater than %d",num2,num1);
}
else{
    printf("%d and %d are equall",num1,num2);
}


    return 0;
}