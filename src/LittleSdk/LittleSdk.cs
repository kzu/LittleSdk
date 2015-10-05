using System;

namespace LittleSdk
{
	/// <summary>
	/// Sample SDK
	/// </summary>
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
