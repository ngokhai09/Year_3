#include<bits/stdc++.h>
using namespace std;
struct sudoku
{
	int a[9][9];
	void input(string fname)
	{
		ifstream fin(fname);
		char c;
		for(int i=0;i<9;i++)
		for(int j=0;j<9;j++)
		{
			fin>>c;
			a[i][j]=c-'0';
		}
		fin.close();
	}
	void output()
	{
		for(int i=0;i<9;i++)
		{
			for(int j=0;j<9;j++) cout<<a[i][j]<<" ";
			cout<<"\n";
		}
	}
	void TRY(int u,int v)
	{
		if(u>8) {output(); return;}
		if(a[u][v]) TRY(u+v/8,(v+1)%9);
		else
		{
			for(int t=1;t<=9;t++)
			if(check(u,v,t))
			{
				a[u][v]=t; TRY(u+v/8,(v+1)%9);
				a[u][v]=0;	
			}
		}
	}
	bool check(int u,int v,int t)
	{
		for(int i=0;i<9;i++) if(a[u][i]==t || a[i][v]==t) return 0;
		for(int i=u/3*3;i<u/3*3+3;i++)
		for(int j=v/3*3;j<v/3*3+3;j++) if(a[i][j]==t) return 0;
		return 1;
	}
};
int main()
{
	sudoku S;
	S.input("s1.cpp");
	S.output();
	cout<<"\nKet qua \n";
	S.TRY(0,0);
}


