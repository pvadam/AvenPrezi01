using System;

namespace BankAccount
{
	public class Logger : ILogger {
		
		public Logger() {
		}
		
		public void Debug(string msg) {
			Console.WriteLine($"Debug: {msg}");
		}
		
		public void Info(string msg) {
			Console.WriteLine($"Info: {msg}");
		}
		
		public void Error(string msg) {
			Console.WriteLine($"Error: {msg}");
		}
		
		public void Warning(string msg) {
			Console.WriteLine($"Warning: {msg}");
		}
		
		public void Log(string msg) {
			Console.WriteLine($"Log: {msg}");
		}
	}
}