#pragma once
#include <map>
#include <vector>
#include <string>

using namespace std;

class Trie
{
	class TrieNode;

	typedef map<char, TrieNode*> TrieMap;
	typedef map<char, TrieNode*>::iterator TrieMapIter;

	// Internal TrieNode class - not relevant outside Trie
	class TrieNode
	{
	public:
		TrieNode(char c = '\0', bool cw = false, TrieNode* p = nullptr) :
			val(c), parent(p), completesWord(cw)
		{
			children.clear();
		}

		char val;
		TrieNode* parent;
		bool completesWord;
		TrieMap children;
	};



public:
	Trie()
	{
		root = new TrieNode('\0', true);
	}


	~Trie()
	{

	}


	void insert(string str) const
	{
		// YOUR CODE GOES HERE
	}


	bool search(string str) const
	{
		// YOUR CODE GOES HERE
	}


	void remove(string str) const
	{
		// YOUR CODE GOES HERE
	}

	void findAllWithPrefix(string prefix, vector<string>& strings) const
	{
		// YOUR CODE GOES HERE
	}


private:

	// findPrefixEnd: 
	// Sets the parameter end to the last node in the prefix of str and returns the length of the prefix
	unsigned int findPrefixEnd(string str, TrieNode*& end) const
	{
		TrieNode* cur = root;
		TrieMapIter res;
		unsigned int i = 0;

		// Find (part of) key already in trie
		for (; i < str.length(); i++)
		{
			if ((res = cur->children.find(str[i])) != cur->children.end())
			{
				cur = res->second;
			}
			else break;
		}

		end = cur;
		return i;
	}


	TrieNode* root;
};
