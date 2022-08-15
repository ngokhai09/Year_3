#include<bits/stdc++.h>
using namespace std;
typedef pair<double,double> Diem;
#define x first
#define y second
double dt(Diem A,Diem B) {return A.x*B.y-A.y*B.x;}
int main()
{
	int n;
	cin>>n;
	Diem A[n]; for(auto &M:A) cin>>M.x>>M.y;   //nhap day diem
	double s=dt(A[n-1],A[0]);
	for(int i=1;i<n;i++) s+=dt(A[i-1],A[i]);
	cout<<"Dien tich da giac "<<abs(s)/2;
}


