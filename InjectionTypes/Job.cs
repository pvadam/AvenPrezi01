//  using System.Runtime.Extensions;

namespace InjectionTypes
{
	public class Job
	{
		public void SetLogger(ILogger sourceLogger) { logger = sourceLogger; }
		
		private ILogger logger { get; set; }
		static System.Random rnd = new System.Random();
		double id = 0;
		
		public Job()
		{
			id = rnd.NextDouble();
		}
		
		public void Display() {
			if (logger != null)
				logger.WriteToLog($"Job id {id}");
		}
	}
}