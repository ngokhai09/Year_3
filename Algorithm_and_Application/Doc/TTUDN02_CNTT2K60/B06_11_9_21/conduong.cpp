//recursion
#include<bits/stdc++.h>
using namespace std;
class zero
{
	int n;
	unordered_map<int,bool> M;
	void dfs(int n)
	{
		M[n]=true;
		if(n)
		{
			for(int a=1;a*a<=n;a++)
			if(n%a==0)
			{
				int m=(a-1)*(n/a+1);
				if(M.find(m)==M.end()) dfs(m);
			}
		}
	}
	public: void sol() 
	{
		cin>>n; dfs(n);
		for(auto x=M.begin();x!=M.end();x++) cout<<x->first<<" ";
		//M.clear();
	}
};
int main()
{
	zero Z; Z.sol();	
}


