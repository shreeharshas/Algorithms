class FindRotatedArray {
     public static void main(String[] args) {
         int[] A = {1,2,3,5,6,7,8};
         int[] B = {5,6,7,8,1,2,3};
         
         
         if(A.length!=B.length){
             System.out.println("No:length mismatch");
             return;
         }
         
         int[] C = new int[A.length*2];
         
         for(int i=0, j=0;i<C.length;++i,++j){
             if(j==A.length)
                 j=0;
             C[i] = A[j];
         }        
         
         /*for(int i=0;i<C.length;i++){
             System.out.println("C["+i+"]="+C[i]);
         }*/
         
         int counter = 0;
         int k = 0;
         for(int i=0;i<C.length;i++){   //k to B //i to C
             if(k==B.length){
                 k=0;
             }
             
             if(C[i]==B[k]){  //if the corresponding indices match
                 System.out.println("C[i], B[k] = " +C[i]+" "+B[k]);
                 k++;
             }
             else{
                 k=0;
             }
             if(k==B.length){
                 System.out.println("Yes");
                 return;
             }
         }         
         if(k==B.length){
             System.out.println("Yes");
         }
         else{
             System.out.println("No");
         }
     }
}
