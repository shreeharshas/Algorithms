public Node getSuccessor(Node n){
   Node pointer = n;
   
      
   
      if(pointer.right!=null){
         pointer = pointer.right;
         while(pointer.left!=null){
            pointer = pointer.left;
         }
         return pointer;
      }
   
      Node ancestor = pointer.parent;
      Node child = pointer;
      while (ancestor !=null && ancestor.right==pointer) {
         /*if(pointer.parent==null)
            return null;
         return pointer.parent;*/
         return ancestor;
      }
   
   
   
  /* right ->traverse left subtree
   no right -> return parent
   right leaf -> root
   */
   
}
