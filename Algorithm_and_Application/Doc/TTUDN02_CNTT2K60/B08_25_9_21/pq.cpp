//cai dat hang doi uu tien bang mang
#include<bits/stdc++.h>
using namespace std;
#ifndef __pq__cpp__
#define __pq__cpp__
template <class T,class K>
class PQ
{
	int n,cap; //n-size, cap-capacity
	T *buf;
	K ss;
		void heapdown(int k)
		{
			if(2*k+1>=n) return;
			int p=2*k+1;
			if(p+1<n && ss(buf[p],buf[p+1])) p++;
			if(ss(buf[k],buf[p]))  
			{
				swap(buf[k],buf[p]);
				heapdown(p);
			}
		}
	public:
		PQ(){n=cap=0; buf=0;}
		~PQ(){if(buf) delete[]buf;}
		bool empty() {return n==0;}
		int size() {return n;}
		T top(){return buf[0];}
		void pop()
		{
			n--;
			buf[0]=buf[n];
			heapdown(0);
		}
		void push(T x)
		{
			if(n==cap) //day thi mo rong mang chua
			{
				cap=2*cap+1;
				T *tem=new T[cap];
				for(int i=0;i<n;i++) tem[i]=buf[i];
				if(buf) delete[]buf;
				buf=tem;
			}
			buf[n++]=x;
			int k=n-1;
			while(k>0 && ss(buf[(k-1)/2],buf[k])) 
			{
				swap(buf[(k-1)/2],buf[k]); 
				k=(k-1)/2;
			}
		}
};
#endif
