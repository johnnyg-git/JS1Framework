using System.Runtime.InteropServices;

namespace Pathfinding.Ionic.Zip
{
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	public class BadCrcException : ZipException
	{
		public BadCrcException()
		{
		}

		public BadCrcException(string message)
		{
		}
	}
}
