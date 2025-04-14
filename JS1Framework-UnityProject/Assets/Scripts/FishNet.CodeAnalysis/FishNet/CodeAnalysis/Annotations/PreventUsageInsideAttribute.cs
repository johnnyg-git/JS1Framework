using System;

namespace FishNet.CodeAnalysis.Annotations
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	public sealed class PreventUsageInsideAttribute : Attribute
	{
		public string FullyQualifiedTypeName { get; }

		public string MemberName { get; }

		public string AdditionalInformation { get; }

		public PreventUsageInsideAttribute(string fullyQualifiedTypeName, string memberName, string additionalInformation = "")
		{
		}
	}
}
