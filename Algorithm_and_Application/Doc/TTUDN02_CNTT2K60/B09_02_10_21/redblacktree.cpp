#include<bits/stdc++.h>
using namespace std;

struct node
{
	int elem;
	bool color;
	node *lef,*rig,*far;
	node(int x,node *f=0)
	{
		elem=x;
		color=1;
		lef=rig=0; far=f;
	}
};

class tree
{
	node *root=0;
	int n;
	list<int> L;
	list<int>::iterator curr;
	void rotate_right(node *&H)
	{
		node *p=H->lef,*q=H->far,*r=p->rig;
		H->lef=r; 
		if(r) r->far=H;
		if(q) {H==q->lef?q->lef=p:q->rig=p;}
		else root=p;
		p->far=q;
		H->far=p;
		p->rig=H;
		H=p;
	}	
	void rotate_left(node *&H)
	{
		node *p=H->rig,*q=H->far,*r=p->lef;
		H->rig=r; 
		if(r) r->far=H;
		if(q) {H==q->lef?q->lef=p:q->rig=p;}
		else root=p;
		p->far=q;
		H->far=p;
		p->lef=H;
		H=p;		
	}
	void conflict(node *p)
	{
		if(p->color==0) return;
		if(p==root) {p->color=0; return;}
		node *q=p->far;
		if(q->color==0) return;
		node *r,*o=q->far;
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
	node *add(node*&H,int x)
	{
		if(!H) {H=new node(x); H->color=0; return H;}
		if(x<H->elem)
		{
			if(H->lef) return add(H->lef,x); 
			return H->lef=new node(x,H);
		}
		else
		{
			if(H->rig) return add(H->rig,x); 
			return H->rig=new node(x,H);
		}
		
	}
	void inorder(node *H)
	{
		if(H) {inorder(H->lef); L.push_back(H->elem); inorder(H->rig);}
	}
	void print(node *H,string pr="\n")
	{
		if(H) 
		{
			print(H->lef,pr+"\t"); 
			cout<<pr<<H->elem<<":"<<H->color; 
			print(H->rig,pr+"\t");
		}
	}
	public: 
		typedef list<int>::iterator iterator;
		iterator begin()
		{
			L.clear();
			inorder(root);
			return L.begin();
		}
		iterator end() {return L.end();}
		tree() {n=0;root=0;}
		int size() {return n;}
		void insert(int x) 
		{
			n++; 
			node *p=add(root,x); 
			conflict(p);
		}
		void travel() {print(root);}//inorder(root);}
};
int main()
{
	tree T; 
	for(int x:{43,47,12,48,60,79,23,55,62,235,34,111,25,252,52,35}) T.insert(x);
//	for(tree::iterator it=T.begin();it!=T.end();it++) cout<<*it<<" ";
	for(auto c:T) cout<<c<<" ";
}


