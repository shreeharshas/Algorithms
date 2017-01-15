#include <stdio.h>
#include <malloc.h>
/*You are given a pointer to the root of a binary tree. Print the top view of the binary tree. 
You only have to complete the function. 
For example :

     3
   /   \
  5     2
 / \   / \
1  4 6   7
 \       /
  9     8

Top View : 1 -> 5 -> 3 -> 2 -> 7*/

struct node
{
    int data;
    node* left;
    node* right;
};

void top_view(node * root)
{
    leftRec(t->left);
    printf("%d->",root.data);
    rightRec(t->right);
}

void leftRec(struct node *t){
    if(t->left != null){
        leftRec(t->left);
    }
    printf("%d->",t.data);
}

void rightRec(struct node *t){
    printf("%d->",t.data);
    if(t->right != null){
        rightRec(t->right);
    }
}

int main(){
    struct node* root = malloc(sizeof(struct node));
    root->data = 3;
    root->left = malloc(sizeof(struct node));
    root->left.data = 5;
    top_view(root);
}
