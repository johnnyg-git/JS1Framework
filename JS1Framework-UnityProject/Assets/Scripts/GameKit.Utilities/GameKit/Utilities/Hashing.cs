namespace GameKit.Utilities
{
	public static class Hashing
	{
		private const uint FNV_offset_basis32 = 2166136261u;

		private const uint FNV_prime32 = 16777619u;

		private const ulong FNV_offset_basis64 = 14695981039346656037uL;

		private const ulong FNV_prime64 = 1099511628211uL;

		public static ushort GetStableHashU16(this string txt)
		{
			return 0;
		}

		public static uint GetStableHashU32(this string txt)
		{
			return 0u;
		}

		public static ulong GetStableHashU64(this string txt)
		{
			return 0uL;
		}
	}
}
