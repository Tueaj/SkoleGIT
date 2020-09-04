#pragma comment(lib,"../x64/Debug/Toolkit.lib")

#include <iostream>
#include "../Toolkit/GraphToolkit.h"
#include "../Toolkit/PriorityQueue.h"
#include "Heuristics.h"

using namespace Graphs;

// A priority queue node: Contains a graph node pointer and a priority
struct PQNode
{
	PQNode(Node* n, double p) : node(n), priority(p) {}
	Node* node;
	double priority;
};


// A PQNode comparator: The ()-operator returns true iff left node's priority is 
// higher thatn the right node's
struct CompareNodes
{
	bool operator()(const PQNode* l, const PQNode* r) const
	{
		return l->priority > r->priority;
	}
};

typedef priority_queue<PQNode*, vector<PQNode*>, CompareNodes> PQueue;

using namespace Graphs;
using namespace std;

int aStar(Graph g, Node* startNode, Node* endNode, double(*h)(Node*, Node*), double hWeight = 1)
{
	reset(g); // Set default cost to infinity
	PriorityQueue<Node*> frontier;
	int nNodesVisited = 0;
	startNode->cost = 0;

	
	PQueue frontier;
	PQNode* startPQNode = new PQNode(startNode, 0);
	int nNodesVisited = 0;


	// Initialize
	reset(g);
	startPQNode->node->cost = 0;
	frontier.push(startPQNode); //Node to start search  from "The start node"


	// Iterate
	while (frontier.size() > 0)
		{
			PQNode* current = frontier.top();//Node to search from 
			frontier.pop(); //remove from frontier

			++nNodesVisited;
			if (current->node == endNode)
			{
				while (frontier.size() > 0)
				{
					current = frontier.top();//Node to search from 
					frontier.pop(); //remove from frontier
					delete current;
				}
				return nNodesVisited;
			}

			for (EdgeListIter edge = current->node->neighbors.begin(); edge != current->node->neighbors.end(); ++edge)
			{
				if (!*edge) continue;//Current node neighbors empty
				Node* next = (*edge)->to; //Next neighbor node
				if ((next->cost > current->node->cost + (*edge)->weight) || (next != nullptr && next->prev == nullptr)) //if next neighbor exits and is not yet visited then add to frontier and mark visted
				{
					next->prev = current->node;
					next->cost = current->node->cost + (*edge)->weight;
					PQNode*  nextPQ = new PQNode(next, next->cost);
					frontier.push(nextPQ);
				}
			}
			delete current;
		}
	return nNodesVisited;
}


int main()
{
	Graph graph;
	
	createFourWayGrid(graph, 10);

	createWall(graph, 2, 2);
	createWall(graph, 3, 2);
	createWall(graph, 3, 3);
	createWall(graph, 3, 4);
	createWall(graph, 3, 5);
	createWall(graph, 4, 5);
	createWall(graph, 5, 3);
	createWall(graph, 6, 5);
	createWall(graph, 7, 5);
	
	Node* S = findNode(graph, "[5;1]");
	Node* T = findNode(graph, "[3;6]");

	int nNodesVisited = aStar(graph, S, T, manhattan, 5.0);

	cout << "Path:   ";
	printPath(graph, S, T);
	
	cout << endl << "Nodes visited: " << nNodesVisited << endl;

	return 0;
}






