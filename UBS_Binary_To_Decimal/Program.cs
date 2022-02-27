// C# Program to find decimal value of
// binary linked list
using System;

class GFG
{

	// Link list Node /
	//public class Node
	//{
	//	public Boolean data;
	//	public Node next;
	//};

	// Returns decimal value of binary linked list
	//static int decimalValue(Node head)
	//{
	//	// Initialized result
	//	int res = 0;

	//	// Traverse linked list
	//	while (head != null)
	//	{
	//		// Multiply result by 2 and add
	//		// head's data
	//		res = (res << 1) + (head.data ? 1 : 0);

	//		// Move next
	//		head = head.next;
	//	}
	//	return res;
	//}

	// Utility function to create a new node.
	//static Node newNode(int data)
	//{
	//	Node temp = new Node();
	//	temp.data = (data == 1 ? true : false);
	//	temp.next = null;
	//	return temp;
	//}

	static double decimalValueList(List<bool> boolList)
	{
		double res = 0;

		boolList.Reverse();
		for (int i = 0; i < boolList.Count; i++)
        {
			int item = boolList[i] ? 1 : 0;
			res = res + Math.Pow(2, i) * item;

		}

		return res;
	}

	// Driver cod
	public static void Main(String[] args)
	{
		// Start with the empty list
		//Node head = newNode(1);
		//head.next = newNode(0);
		//head.next.next = newNode(1);
		//head.next.next.next = newNode(1);

		//Console.WriteLine("Decimal value is " +
		//				decimalValue(head));

		List<bool> boolList = new List<bool>();
		boolList.Add(true);
		boolList.Add(false);
		boolList.Add(true);
		boolList.Add(false);

		Console.WriteLine("Decimal value is " + decimalValueList(boolList));
	}
}