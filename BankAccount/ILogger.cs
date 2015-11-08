using System;

namespace BankAccount
{
	public interface ILogger {
		
		void Debug(string msg);
		void Info(string msg);
		void Error(string msg);
		void Warning(string msg);
		void Log(string msg);
	}
}