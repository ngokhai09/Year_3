//trung vi
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
int main()
{
	int n,x;
	node *H=0;
	cin>>n;
	for(int i=1;i<=n;i++)
	{
		cin>>x;
		if(i==1) H=new node(x);
		else
		{
			if(i%2) 
			{
				if(x<=H->elem) add(H->L,x);
				else
				{
					add(H->L,H->elem);
					add(H->R,x);
					H->elem=Min(H->R);
					remove(H->R,H->elem);
				}
			}
			else
			{
				if(x>=H->elem) add(H->R,x);
				else
				{
					add(H->R,H->elem);
					add(H->L,x);
					H->elem=Max(H->L);
					remove(H->L,H->elem);
				}
			}
		}
		cout<<H->elem<<" ";
	}
}


