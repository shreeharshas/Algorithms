include <iostream>
include <unordered_map>
using namespace std;

struct Node {
int data;
Node * next;
};

void removeDuplicates(Node *lst) {
unordered_map hashmap;
struct Node *prev = lst;

while(lst!=null){//loop through list
if(hashmap.contains(lst.data)){//check if already present in hashmap
                                prev  lst
// 12->34->45->12->null
prev->next=lst->next;
lst=lst->next;
}
else{
hashmap.add(lst.data);
prev=lst;
lst=lst->next;
}
}
}

