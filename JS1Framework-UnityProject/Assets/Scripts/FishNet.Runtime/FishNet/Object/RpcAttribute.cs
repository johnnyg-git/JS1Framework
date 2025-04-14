using System;

namespace FishNet.Object
{
	[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
	public class RpcAttribute : Attribute
	{
		public bool RunLocally;

		public int DataLength;

		public DataOrderType OrderType;
	}
}
