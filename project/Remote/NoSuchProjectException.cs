using ThoughtWorks.CruiseControl.Core;

namespace ThoughtWorks.CruiseControl.Remote
{
	public class NoSuchProjectException : CruiseControlException
	{
		private readonly string requestedProject;

		public string RequestedProject
		{
			get { return requestedProject; }
		}

		public NoSuchProjectException(string requestedProject) : base ()
		{
			this.requestedProject = requestedProject;
		}
	}
}
