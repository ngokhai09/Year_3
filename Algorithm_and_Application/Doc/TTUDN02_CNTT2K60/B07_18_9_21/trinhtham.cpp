//trinh tham
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,k;
	cin>>n>>k;
	int a[n+5];
	deque<int> L; 
	for(int i=1;i<=n;i++) 
	{
		cin>>a[i];
		while(L.size() && a[L.back()]<=a[i]) L.pop_back();
		L.push_back(i);
		while(i-L.front()+1>k) L.pop_front();
		if(i>=k) cout<<a[L.front()]<<" ";
	}
}


