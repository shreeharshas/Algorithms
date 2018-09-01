// Example program
#include <iostream>
#include <string>
#include <unordered_map>
//C++ program to remove duplicates in a linked list

using namespace std;

struct Node {
  int data;
  Node * next;
};

void printList(struct Node *node){
    struct Node *n = node;
    while(n!=NULL){
        cout<<node->data<<"-->";
        n=n->next;
    }
    cout<<"NULL"<<endl;
}

void removeDuplicates(Node *lst) {
  unordered_map<int,int> hashmap;
  struct Node *prev = lst;

  while(lst!=NULL){//loop through list
    auto find_out = hashmap.find(lst->data);
    if(find_out!=hashmap.end()){//check if already present in hashmap
      // prv lst
      // 12->34->45->12->null
      prev->next=lst->next;
      lst=lst->next;
    }
    else{
      hashmap.insert(make_pair(lst->data,lst->data));
      prev=lst;
      lst=lst->next;
    }
  }
}

int main(){
    struct Node *head, *second, *third, *fourth, *fifth;
    head->data = 56;
    second->data = 45;
    third->data = 56;
    fourth->data = 88;
    fifth->data = 123;
    
    head->next=second;
    second->next=third;
    third->next=fourth;
    fourth->next=fifth;
    head->next=NULL;
    
    cout<<"Before:"<<endl;
    printList(head);
    removeDuplicates(head);
    cout<<"After:"<<endl;
    printList(head);
    return 0;
}
