using System;
using UnityEngine;

namespace RootMotion
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute
	{
		public string propName { get; protected set; }

		public object propValue { get; protected set; }

		public object otherPropValue { get; protected set; }

		public bool indent { get; private set; }

		public ShowIfMode mode { get; protected set; }

		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
}
