#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,L,R;
	cin>>n>>L>>R;
	long long a,c[n+5],res=-INT_MAX;
	deque<int> Q;	//luu cac chi so cua day giam dan trong
	for(int i=1;i<=n;i++) 
	{
		cin>>a;
		if(i<=L) c[i]=a;
		else
		{
			while(Q.size() && c[Q.back()]<=c[i-L]) Q.pop_back();
			if(c[i-L]>0) Q.push_back(i-L);
			while(i-Q.front()>R) Q.pop_front();
			c[i]=a+(Q.size()?c[Q.front()]:0);
		}
		if(res<c[i]) res=c[i];
	}
	cout<<res;	
}


