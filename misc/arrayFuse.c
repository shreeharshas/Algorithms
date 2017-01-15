/*Given two sorted arrays - capacity 40 and 100, first filled completely and second 60 filled, merge these two without extra spaces*/
/*Written code for 4 and 10 - multiply by 10 for actual capacity*/

#include <stdio.h>

int main(int argc, char *argv[]){
	int a4[4] = {6,7,8,9};
	int a10[10] = {1,2,3,4,5,6};
	int i=3,j=5,k,l;
	
	for(l=9;l>=0;){
		if(i>=0){
			if(a4[i]>a10[j])
				a10[l--] = a4[i--];
			else
				a10[l--] = a10[j--];
		}
		else
			a10[l--] = a10[j--];
			
		for(k=0;k<10;k++){
			printf("%d ",a10[k]);
		}
		printf("\n");
	}
	return 0;
}
