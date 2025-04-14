using System;
using System.IO;

namespace Pathfinding.Ionic.Crc
{
	public class CrcCalculatorStream : Stream, IDisposable
	{
		private static readonly long UnsetLengthLimit;

		internal Stream _innerStream;

		private CRC32 _Crc32;

		private long _lengthLimit;

		private bool _leaveOpen;

		public long TotalBytesSlurped => 0L;

		public int Crc => 0;

		public bool LeaveOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public CrcCalculatorStream(Stream stream)
		{
		}

		public CrcCalculatorStream(Stream stream, bool leaveOpen)
		{
		}

		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		{
		}

		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		{
		}

		private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
		{
		}

		void IDisposable.Dispose()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Close()
		{
		}
	}
}
