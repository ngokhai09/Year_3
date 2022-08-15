//Cho ham f lien tuc [a,b] co f(a)*f(b)<=0 tim x thuoc [a,b] sao cho f(x)=0
#include<bits/stdc++.h>
using namespace std;

double gpt(double a,double b,double f(double))
{
	double eps=1e-8;
	while(b-a>eps)
	{
		double c=(a+b)/2;
		f(a)*f(c)<=0?b=c:a=c;
	}
	return (a+b)/2;
}
int main()
{
	cout<<"Pi = "<<setprecision(20)<<fixed<<gpt(3,3.5,sin);

}


