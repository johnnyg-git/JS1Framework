using System.IO;

namespace Pathfinding.Ionic.BZip2
{
	internal class WorkItem
	{
		public int index;

		public MemoryStream ms;

		public int ordinal;

		public BitWriter bw;

		public BZip2Compressor Compressor { get; private set; }

		public WorkItem(int ix, int blockSize)
		{
		}
	}
}
