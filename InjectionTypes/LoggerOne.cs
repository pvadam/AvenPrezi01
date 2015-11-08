using System;

namespace InjectionTypes
{
	public class LoggerOne : ILogger
	{
		public void WriteToLog(string text)
		{
			Console.WriteLine(text);
		}
	}
}