using System;

public class ClassB : ClassA
{
    public ClassB() : this("B0", 0)
    {
    }

	public ClassB(
        string msg, 
        int count = 1) : base(msg)
	{
        Console.Write("B:" + msg);
        for (int i = 0; i < count; i++)
        {
            Console.Write(".");
        }
        Console.Write(" ");
	}
}
