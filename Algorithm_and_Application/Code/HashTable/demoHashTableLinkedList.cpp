#include<bits/stdc++.h>

using namespace std;
const int MAX_SIZE = 1e3 + 3;
class HashTable{
	private:
		vector<string> hashtable[MAX_SIZE];
	public:
		HashTable(){
			}
		int hashFunc(int key){
			return key % MAX_SIZE;
		}
		int hashFunction(int key){
			double 	A = (sqrt(5) - 1) / 2;
			return MAX_SIZE * (key * A);
		}
		int handleValue(string value){
			int sum = 0;
			for(int i = 0; i < value.length(); i++){
				sum += (int)value[i];
			}
			return sum;
		}
		void insert(string s){
			int index = hashFunc(handleValue(s));
			hashtable[index].push_back(s);
		}
		void search(string s){
			int index = hashFunc(handleValue(s));
			int isExists = 0;
			for(int i = 0; i < hashtable[index].size(); i++){
				if(hashtable[index][i] == s){
					cout << "Found at " << index << endl;
					isExists = 1;
				}
			}
			if(!isExists)
				cout << "Not Found" << endl;
		}
};
int main(){
	HashTable hashTable;
	hashTable.insert("abc");
	hashTable.insert("acd");
	hashTable.insert("adc");
	
	hashTable.search("abc");
	hashTable.search("acd");
	hashTable.search("adc");
}
