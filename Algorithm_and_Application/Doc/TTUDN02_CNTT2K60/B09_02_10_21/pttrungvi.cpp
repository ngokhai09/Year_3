//trung vi
#include<bits/stdc++.h>
#include"pq.cpp"
using namespace std;
int main()
{
	PQ<int,less<int> > L;
	//priority_queue<int,vector<int>,greater<int>> R;
	PQ<int,greater<int> > R;
	int n,x,y;
	cin>>n;
	for(int i=1;i<=n;i++)
	{
		cin>>x;
		i%2?L.push(x):R.push(x);
		if(i>1 && L.top()>R.top())
		{
			x=L.top(); y=R.top(); L.pop();R.pop(); L.push(y);R.push(x);	
		} 
		cout<<L.top()<<" ";		
	}
}


