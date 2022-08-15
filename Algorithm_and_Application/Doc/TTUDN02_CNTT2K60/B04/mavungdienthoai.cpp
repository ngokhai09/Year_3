#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<int,string> M={{61,"Brasilia"},{71,"Salvador"},{11,"Sao Paulo"},
	{21,"Rio de Janeiro"},{32,"Juiz de Fora"},{19,"Campinas"},{27,"Vitoria"},
	{31,"Belo Horizonte"}};
//	int n;
//	cin>>n;
//	if(M.find(n)!=M.end()) cout<<M[n];
//	else cout<<"DDD nao cadastrado";
	for(auto m:M) cout<<m.first<<" "<<m.second<<"\n";
}


