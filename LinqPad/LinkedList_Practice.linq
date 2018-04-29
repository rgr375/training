<Query Kind="Program" />

void Main()
{
	Node n1 = new Node('a');
	n1.AddLast('b');
	n1.Last.Value.ToString().Dump();
	n1.AddLast('c');
	n1.Last.Value.ToString().Dump();
	n1.First.Value.ToString().Dump();
	n1.AddFirst('d');
	n1.First.Value.ToString().Dump();
	while (true) {
		Console.WriteLine(n1.Value.ToString());
		if (n1.Next is null) break;
		n1 = n1.Next;
	}
}

public class LinkedList {
	public int Count = 0;
	private Node Last;
	private Node First = null;
	
	public Node First { get; set; }
	
	public void AddLast(char Character) {
		Node temp = new Node(Character);
		Node curr = this;
		while (curr.Next != null) {
			curr = curr.Next;
		}
		curr.Next = temp;
		Count++;
		Last = curr.Next;
	}
	
	public void AddFirst(char Character) {
		First = new Node(Character, First);
		Count++;
		
	}

	private class Node
	{
		public char data;
		public Node Next;

		public Node(char Character, Node NextNode)
		{
			data = Character;
			Next = NextNode;
		}

		public Node(char Character) : this(Character, null)
		{

		}
	}
}
