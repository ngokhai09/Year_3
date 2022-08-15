#include<bits/stdc++.h>

using namespace std;
const int MAX_SIZE = 1e3 + 3;
class HashTable{
	private:
		string hashtable[MAX_SIZE];
		int size = 0;
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
		void extend(){
//			string tmp[(MAX_SIZE + 1) * 2];
//			delete hashtable;
//			
		}
		void insert(string s){
			int index = hashFunc(handleValue(s));
			int i = 1;
			if(size == MAX_SIZE){
				
			}
			while(hashtable[index] != ""){
//				index = (index + i) % MAX_SIZE;
				index = int (index + pow(i, 2)) % MAX_SIZE;
				i++;
			}
			hashtable[index] = s;
			size++;
		}
		void search(string s){
			int index = hashFunc(handleValue(s));
			int i = 1;
			while(hashtable[index] != s && hashtable[index] != ""){
//				index = (index + i) % MAX_SIZE;
				index = (index + i * i) % MAX_SIZE;
				i++;
			} 
			if(hashtable[index] == s){
				cout << "Found at " << index << endl;
			}
			else{
				cout << "Not found" << endl;
			}
		}
};
int main(){
	HashTable hashTable;
	hashTable.insert("abc");
	hashTable.insert("acd");
	hashTable.insert("adc");
	hashTable.insert("cda");
	
	hashTable.search("abc");
	hashTable.search("adc");
	hashTable.search("acd");
	hashTable.search("cda");
}
