#include<bits/stdc++.h>
using namespace std;
struct node
{
	int elem;
	node *L,*R;
	node(int x,node*t=0,node*p=0) {elem=x;L=t;R=p;}
};
void add(node *&H,int x)
{
	if(H==0) H=new node(x);
	else add(H->elem>x?H->L:H->R,x);
}
int Max(node *H) {return !H->R?H->elem:Max(H->R);}
int Min(node *H) {return !H->L?H->elem:Min(H->L);}

void remove(node *&H,int x)
{
	if(!H) return;
	if(x==H->elem) 
	{
		if(!H->L) H=H->R; 
		else {H->elem=Max(H->L); remove(H->L,H->elem);}
	}
	else remove(x<H->elem?H->L:H->R,x);
}
void inorder(node *H)
{
	if(H) {inorder(H->L); cout<<H->elem<<" "; inorder(H->R);}
}
int main()
{
	node *H=0;
	
	for(int x:{4,7,2,8,4,8,3,2}) add(H,x);
	cout<<"\nCay : "; inorder(H);
	remove(H,3);
	cout<<"\nCay : "; inorder(H);
	
}


