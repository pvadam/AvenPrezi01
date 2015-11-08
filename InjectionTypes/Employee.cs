namespace InjectionTypes
{
	public class Employee
	{
		public Employee(ILogger logger)
		{
			logger.WriteToLog("New employee created");
		}
	}
}