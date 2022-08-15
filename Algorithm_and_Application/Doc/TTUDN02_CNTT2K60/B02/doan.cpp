#include<bits/stdc++.h>
using namespace std;
typedef pair<double,double> point;
#define x first
#define y second
double kc(point A,point B)
{
	return (A.x-B.x)*(A.x-B.x)+(A.y-B.y)*(A.y-B.y);
}
point find(point A,point B,point M)
{
	while(kc(A,B)>1e-6)
	{
		point C={(A.x+B.x)/2,(A.y+B.y)/2};
		kc(A,M)>kc(B,M)?A=C:B=C;
	}
	return A;
}
int main()
{
	point A,B,M,N;
	cin>>A.x>>A.y>>B.x>>B.y>>M.x>>M.y;
	N=find(A,B,M);
	cout<<setprecision(10)<<fixed<<"("<<N.x<<","<<N.y<<")";
}


