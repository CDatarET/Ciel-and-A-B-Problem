using System;

public class Test
{
	public static void Main()
	{
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
		    
		int x = (a - b) % 10;
		if(x != 9){
		    Console.WriteLine(a-b+1);
		}
		else{
		    Console.WriteLine(a-b-1);
	    }
	}
}
