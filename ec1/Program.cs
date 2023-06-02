// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//You are given a node that is the beginning of a linked list. This list contains a dangling piece and a loop. Your objective is to determine the length of the loop. 

//For example in the following picture the tail's size is 3 and the loop size is 11.









//DO I JUST NEED TO MAKE A LINKED LIST? LOL

class Node
{
	public int Data { get; set; }
	public Node Next { get; set; }

	public Node(int data)
	{
		this.Data = data;
	}
}

class Solution
{
	public static int getLoopSize(Node startNode)
	{
		//cut the opeations in half by using a fast and slow pointer

		Node tort = startNode;
		Node hare = startNode.Next;
		//Find a loop
		while (tort != hare)
		{
			tort = tort.Next;
			hare = hare.Next.Next;
			if (tort == null || hare == null)
			{
				//there is no loop
				return 0;
			}
		}
		//if they meet, there is a loop

		int length = 0;
		hare = hare.Next;
		while (tort != hare)
		{
			hare = hare.Next;
			length++;
		}
		return length+1;

		//ez gg (fr this time)
	}
}


//------- THIS TIMED OUT LOL ----------------

		//So im gonna iterate through each node's next, adding to a visited list.
		//Node current = startNode;
		//List<Node> Visited = new List<Node>();
		//int length = 0;
		//while (!Visited.Contains(current.Next) && current != null)
		//{
		//	Visited.Add(current);
		//	current = current.Next;
		//	length++;
		//}

		//if (current.Next == null)
		//{
		//	//there is no loop
		//	return 0;
		//}
		//else
		//{
		//	//length of loop tail is index of current.Next in visited plus 1 cause we never added for current, loop break
		//	return length - Visited.IndexOf(current.Next);
		//	//ez gg
		//}//current should be loop end
		//if node shows up on visited list, return the length of the visited list minus the index of the node.
		//ez gg