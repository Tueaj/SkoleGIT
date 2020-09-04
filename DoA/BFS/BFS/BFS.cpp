#pragma comment(lib,"../x64/Debug/Toolkit.lib")

#include "../Toolkit/GraphToolkit.h"
#include <iostream>
#include <vector>
#include <queue>
#include "../Toolkit/Node.h"

using Graphs::Node;

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

int aStar(Graph g, Node* startNode, Node* endNode)
{

	reset(g); // Set default cost to infinity	startNode->cost = 0;

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
				PQNode* nextPQ = new PQNode(next, next->cost);
				frontier.push(nextPQ);
			}
		}
		delete current;
	}

	return nNodesVisited;
}

int dijkstraPQ(Graph g, Node* startNode, Node* endNode)
{
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
			if ((next->cost > current->node->cost + (*edge)->weight) ||(next != nullptr && next->prev == nullptr)) //if next neighbor exits and is not yet visited then add to frontier and mark visted
			{
				next->prev = current->node;
				next->cost = current->node->cost + (*edge)->weight;
				PQNode* nextPQ = new PQNode(next, next->cost);
				frontier.push(nextPQ);
			}
		}
		delete current;
	}

	return nNodesVisited;
}

int dijkstra(Graph g, Node* startNode, Node* endNode)
{
	queue<Node*> frontier;
	Node* next = nullptr;
	int nNodesVisited = 0;

	// Initialize
	reset(g);
	startNode->cost = 0;
	frontier.push(startNode); //Node to start search  from "The start node"

	// Iterate
	while (frontier.size() > 0)
	{
		Node* current = frontier.front();//Node to search from 
		frontier.pop(); //remove from frontier

		++nNodesVisited;
		if (current != endNode)
		{
			for (EdgeListIter edge = current->neighbors.begin(); edge != current->neighbors.end(); ++edge)
			{
				if (!*edge) continue;//Current node neighbors empty
				next = (*edge)->to; //Next neighbor node
				if (next != nullptr && next->prev == nullptr) //if next neighbor exits and is not yet visited then add to frontier and mark visted
				{
					next->prev = current;
					next->cost = current->cost + (*edge)->weight;
					frontier.push(next);
				}
				else
				{
					if (next->cost > current->cost + (*edge)->weight)
					{
						next->prev = current;
						next->cost = current->cost + (*edge)->weight;
					}
				}
			}
		}
	}

	return nNodesVisited;
}


int bfs(Graph g, Node* startNode, Node* endNode)
{
	queue<Node*> frontier;
	Node* next = nullptr;
	int nNodesVisited = 0;
	
	// Initialize
	reset(g);
	frontier.push(startNode); //Node to start search  from "The start node"

	// Iterate
	while (frontier.size() > 0)
	{
		Node* current = frontier.front();//Node to search from 
		frontier.pop(); //remove from frontier
		
		++nNodesVisited;
		if (current == endNode) return nNodesVisited; //To node reached	


		for (EdgeListIter edge = current->neighbors.begin(); edge != current->neighbors.end(); ++edge)
		{
			if (!*edge) continue;//Current node neighbors empty
			next = (*edge)->to; //Next neighbor node
			if (next != nullptr && next->prev == nullptr) //if next neighbor exits and is not yet visited then add to frontier and mark visted
			{
				next->prev = current;//visited and set path
				frontier.push(next);
			}
		}
	}
	
	return nNodesVisited;
}



int main()
{
	Graph graph;
	readEdgeList(graph, "example-graph-nodelist.txt");
	
	string from = "San_Francisco";
	string to = "Rom";

	int x = dijkstraPQ(graph, findNode(graph, from), findNode(graph, to));
	print(graph);


	/*createFourWayGrid(graph, 10);
	createWall(graph, 3, 3);
	createWall(graph, 3, 4);
	createWall(graph, 3, 5);
	createWall(graph, 4, 5);
	createWall(graph, 5, 5);
	createWall(graph, 6, 5);
	createWall(graph, 7, 5);*/
	Node* s = findNode(graph, from);
	Node* t = findNode(graph, to);

	int nNodesVisited = dijkstraPQ(graph, s, t);

	cout << "Path:   ";
	printPath(graph, s->label, t->label);

	cout << endl << "Nodes visited: " << nNodesVisited << " cost in miles = " << t->cost << endl;
	return 0;
}