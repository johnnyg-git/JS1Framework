using UnityEngine;

namespace Funly.SkyStudio
{
	public class RotateBody : MonoBehaviour
	{
		private float m_SpinSpeed;

		private bool m_AllowSpinning;

		public float SpinSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool AllowSpinning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void UpdateOrbitBodyRotation()
		{
		}
	}
}
