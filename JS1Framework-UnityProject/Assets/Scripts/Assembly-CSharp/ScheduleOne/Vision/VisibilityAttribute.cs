using System;
using UnityEngine;

namespace ScheduleOne.Vision
{
	[Serializable]
	public class VisibilityAttribute
	{
		public string name;

		public float pointsChange;

		[Range(0f, 5f)]
		public float multiplier;

		public VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1)
		{
		}

		public void Delete()
		{
		}
	}
}
