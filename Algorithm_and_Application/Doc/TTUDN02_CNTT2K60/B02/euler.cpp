#include<bits/stdc++.h>
using namespace std;

typedef pair<double,double> point;
#define x first
#define y second
double kc(point A,point B)
{
	return sqrt((A.x-B.x)*(A.x-B.x)+(A.y-B.y)*(A.y-B.y));
}
point Euler(point A,point B,point C)
{
	point M={(A.x+B.x+C.x)/3,(A.y+B.y+C.y)/3};
	double ep=10;//min({kc(A,B),kc(A,C),kc(B,C)})+1;
	double res=kc(A,M)+kc(B,M)+kc(C,M);
	while(ep>1e-8)
	{
		point Next[]={{M.x+ep,M.y},{M.x-ep,M.y},{M.x,M.y+ep},{M.x,M.y-ep}};
		bool ok=0;
		for(auto N:Next)
		{
			double k=kc(A,N)+kc(B,N)+kc(C,N);
			if(k<res) 
			{
				//cout<<"gia tri "<<k<<"\n";
				M=N; res=k; ok=1; break;
			}
		}
		if(ok==0) ep/=2;
	}
	return M;
}
int main()
{
	point A(0,2),B(7,0),C(17,0);
	point N=Euler(A,B,C);
	cout<<setprecision(10)<<fixed<<"("<<N.x<<","<<N.y<<")";

}


