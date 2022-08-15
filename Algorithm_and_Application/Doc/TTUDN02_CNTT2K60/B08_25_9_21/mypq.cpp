//cai dat priority_queue bang cay
#include<bits/stdc++.h>
using namespace std;
#ifndef __mypq__cpp__
#define __mypq__cpp__
template <class T>
struct node
{
	T elem;			//du lieu
	int n;      	//tong so nut tren cay
	node *L,*R;
	node(T x) {elem=x;n=1;L=R=0;}
};

template <class T,class K> //T kieu du lieu, K phep so sanh uu tien
class pq
{
	node<T> *H;
	K ss;
		void add(node<T> *&Z,T x)
		{
			if(ss(Z->elem,x)) swap(Z->elem,x); 
			Z->n++;
			if(Z->L==0) Z->L=new node<T>(x);
			else if(Z->R==0) Z->R=new node<T>(x);
			else add(Z->L->n<Z->R->n?Z->L:Z->R,x);
		}
		void remove(node<T> *&Z)
		{
			if(Z->n==1)  Z=0;  
			else if(!Z->L)  Z=Z->R;
			else if(!Z->R)  Z=Z->L;
			else 
			{
				Z->n--;
				if(ss(Z->R->elem,Z->L->elem)) {Z->elem=Z->L->elem;remove(Z->L);}
				else {Z->elem=Z->R->elem; remove(Z->R);}
			}
		}
	public:
		pq() {H=0;}
		bool empty() {return H==0;}
		int size()	 {if(H) return H->n; return 0;}
		T top(){return H->elem;}
		void push(T x)
		{
			if(H==0) {H=new node<T>(x); return;}
			add(H,x);
		}
		void pop(){remove(H);}
};
#endif

