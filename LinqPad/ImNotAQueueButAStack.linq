<Query Kind="Program" />

void Main()
{
	var trickQueue = new ImAQueueNot('a');
	trickQueue.Enqueue('b');
	trickQueue.Enqueue('c');
	
	while (trickQueue.Count > 0) {
		Console.WriteLine(trickQueue.Dequeue().ToString());
	}
	
}

// Define other methods and classes here
public class ImAQueueNot {
	private Stack<char> s1 = new Stack<char>();
	private Stack<char> s2 = new Stack<char>();
	
	public ImAQueueNot()
	{
		
	}
	
	public ImAQueueNot(char value)
	{
		Enqueue(value);
	}

	public int Count
	{
		get
		{
			return s1.Count;
		}
	}
	
	public void Enqueue(char value) {
		s1.Push(value);
	}
	
	public char Dequeue() {
		swapStacks(s1, s2);
		var item = s2.Pop();
		swapStacks(s2,s1);
		return item;
	}
	
	private void swapStacks(Stack<char> swap1, Stack<char> swap2) {
		while(swap1.Count > 0) {
			swap2.Push(swap1.Pop());
		}
	}
}