using System;

namespace LittleSdk
{
	public class LittleSdk : ILittleSdk
	{
		public void Connect ()
		{
			Console.WriteLine ("Connected!");
		}

		public void Write (string message)
		{
			Console.WriteLine (message);
		}
	}
}
