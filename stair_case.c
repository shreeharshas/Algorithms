/* File           : diagonalDifference.cs
 Author         : Shree Harsha Sridharamurthy
 Author email   : s.shreeharsha@gmail.com
 Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
 Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/staircase
 Description    : Your teacher has given you the task of drawing a staircase structure. Being an expert programmer, you decided to make a program to draw it for you instead. Given the required height, can you print a staircase as shown in the example?

Input 
You are given an integer NN depicting the height of the staircase.

Output 
Print a staircase of height NN that consists of # symbols and spaces. For example for N=6N=6, here's a staircase of that height:

     #
    ##
   ###
  ####
 #####
######
Note: The last line has 0 spaces before it.
*/
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int main(){
    int n, i, j; 
    scanf("%d",&n);
    for(i=n; i>=1; i--){
        for(j=1;j<=n;j++){
            if(j<i){
                printf(" ");
            }
            else{
                printf("#");   
            }            
        }
        printf("\n");
    }
    return 0;
}
