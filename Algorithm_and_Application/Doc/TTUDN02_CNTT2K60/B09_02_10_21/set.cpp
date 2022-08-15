#include<bits/stdc++.h>
using namespace std;

template <class T>
struct node
{
	T elem;
	bool color;
	node *lef,*rig,*far;
	node(T x,node *f=0)
	{
		elem=x;
		color=1;
		lef=rig=0; far=f;
	}
};

template <class Type,class Cmp=less<Type> >
class Set
{
	node<Type> *root=0;
	int n;
	list<Type> L;
	Cmp ss;
	void rotate_right(node<Type> *&H)
	{
		node<Type> *p=H->lef,*q=H->far,*r=p->rig;
		H->lef=r; 
		if(r) r->far=H;
		if(q) {H==q->lef?q->lef=p:q->rig=p;}
		else root=p;
		p->far=q;
		H->far=p;
		p->rig=H;
		H=p;
	}	
	void rotate_left(node<Type> *&H)
	{
		node<Type> *p=H->rig,*q=H->far,*r=p->lef;
		H->rig=r; 
		if(r) r->far=H;
		if(q) {H==q->lef?q->lef=p:q->rig=p;}
		else root=p;
		p->far=q;
		H->far=p;
		p->lef=H;
		H=p;		
	}
	void conflict(node<Type> *p)
	{
		if(p->color==0) return;
		if(p==root) {p->color=0; return;}
		node<Type> *q=p->far;
		if(q->color==0) return;
		node<Type> *r,*o=q->far;
		r=(q==o->lef?o->rig:o->lef);
		if(r && r->color) {q->color=r->color=0; o->color=1; conflict(o);}
		else 
		{
			if(o->lef==q)
			{
				if(p==q->rig) rotate_left(q);
				q->color=0;
				o->color=1;
				rotate_right(o); 
			}
			else
			{
				if(p==q->lef) rotate_right(q);
				q->color=0;
				o->color=1;
				rotate_left(o);
			}
		}
	}
	node<Type> *add(node<Type>*&H,Type x)
	{
		if(!H) {H=new node<Type>(x); H->color=0; return H;}
		if(ss(x,H->elem))
		{
			if(H->lef) return add(H->lef,x); 
			return H->lef=new node<Type>(x,H);
		}
		else
		{
			if(H->rig) return add(H->rig,x); 
			return H->rig=new node<Type>(x,H);
		}
	}
	node<Type> *find(node<Type> *H,Type x)
	{
		if(!H || H->elem==x) return H;
		return find(x<H->elem?H->lef:H->rig,x);
	}
	void inorder(node<Type> *H)
	{
		if(H) {inorder(H->lef); L.push_back(H->elem); inorder(H->rig);}
	}
//	void print(node<Type> *H,string pr="\n")
//	{
//		if(H) 
//		{
//			print(H->lef,pr+"\t"); 
//			cout<<pr<<H->elem<<":"<<H->color; 
//			print(H->rig,pr+"\t");
//		}
//	}
	public: 
		typedef list<int>::iterator iterator;
		iterator begin()
		{
			L.clear();
			inorder(root);
			return L.begin();
		}
		iterator end() {return L.end();}
		Set() {n=0;root=0;}
		int size() {return n;}
		void insert(Type x) 
		{
			node<Type> *p=find(root,x); if(p) return;
			n++;
			p=add(root,x); 
			conflict(p);
		}
		void travel() {print(root);}//inorder(root);}
};
int main()
{
	Set<int,greater<int>> T; 
	for(int x:{43,47,12,48,60,79,23,48,25,55,62,235,34,48,111,25,252,52,35}) T.insert(x);
	for(Set<int>::iterator it=T.begin();it!=T.end();it++) cout<<*it<<" ";
//	for(auto c:T) cout<<c<<" ";
}


