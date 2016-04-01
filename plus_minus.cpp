/*# File           : diagonalDifference.cs
 Author         : Shree Harsha Sridharamurthy
 Author email   : s.shreeharsha@gmail.com
 Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
 Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/plus-minus
 Description    : Given an array of integers, calculate which fraction of the elements are positive, negative, and zeroes, respectively. Print the decimal value of each fraction.

Input Format

The first line, NN, is the size of the array. 
The second line contains NN space-separated integers describing the array of numbers (A1,A2,A3,⋯,ANA1,A2,A3,⋯,AN).

Output Format

Print each value on its own line with the fraction of positive numbers first, negative numbers second, and zeroes third.

Sample Input

6
-4 3 -9 0 4 1         
Sample Output

0.500000
0.333333
0.166667
Explanation

There are 3 positive numbers, 2 negative numbers, and 1 zero in the array. 
The fraction of the positive numbers, negative numbers and zeroes are 36=0.50000036=0.500000, 26=0.33333326=0.333333 and 16=0.16666716=0.166667, respectively.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10−410−4 are acceptable.
*/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
//#include <iomanip>
using namespace std;


int main(){
    int n;
    cin >> n;
    vector<int> arr(n);
    for(int arr_i = 0;arr_i < n;arr_i++){
       cin >> arr[arr_i];
    }
    
    if(n>0){
        float pos_c = 0, neg_c = 0, zero_c = 0;
        for(int arr_i = 0; arr_i < n; arr_i++){
            if(arr[arr_i] == 0){
                zero_c++;
            }
            else if(arr[arr_i] > 0){
                pos_c++;
            }
            else{
                neg_c++;
            }
        }
        //cout << left << setfill('0') << setw(8) << pos_c/n <<endl << neg_c/n << endl << zero_c/n;
        cout<< pos_c/n <<endl << neg_c/n << endl << zero_c/n;
    }
    else{
        cout<< "0.000000" << endl << "0.000000" <<endl <<"0.000000";
    }
    return 0;
}
