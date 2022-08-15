//sinh test
#include<bits/stdc++.h>
using namespace std;
int myrand()
{
	return rand()%90+10;
}
int main()
{
	srand(time(0));
	int n=13,a[25][25]={};
	freopen("a5.in","w",stdout);
	cout<<n<<"\n";
	for(int i=1;i<=n;i++)
	for(int j=i+1;j<=n;j++) a[i][j]=a[j][i]=myrand();
	for(int i=1;i<=n;i++)
	{
		for(int j=1;j<=n;j++) cout<<a[i][j]<<" ";
		cout<<"\n";
	}
}


