using System;

namespace Function
{
	public class FunctionHandler
	{
		public void Handle(string input)
		{
			Request.SetContext(input);
			
			Console.WriteLine("Hi there - your input was: {0}",input);
		}
	}
}
