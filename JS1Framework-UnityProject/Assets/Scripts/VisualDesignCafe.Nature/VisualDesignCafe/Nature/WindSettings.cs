using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VisualDesignCafe.Nature
{
	[Serializable]
	public struct WindSettings
	{
		[FormerlySerializedAs("GustDirection")]
		public Vector2 WindDirection;

		[FormerlySerializedAs("GustStrength")]
		[Range(0f, 1f)]
		public float WindStrength;

		[FormerlySerializedAs("GustSpeed")]
		[Range(0.5f, 1f)]
		public float WindSpeed;

		[FormerlySerializedAs("ShiverStrength")]
		[Range(0f, 1f)]
		public float Turbulence;

		public static WindSettings None => default(WindSettings);

		public static WindSettings Calm => default(WindSettings);

		public static WindSettings Breeze => default(WindSettings);

		public static WindSettings StrongBreeze => default(WindSettings);

		public static WindSettings Storm => default(WindSettings);

		public static WindSettings FromWindZone(WindZone windZone)
		{
			return default(WindSettings);
		}

		public static Vector2 RotationToDirection(Quaternion quaternion)
		{
			return default(Vector2);
		}

		public WindSettings(WindSettings other)
		{
			WindDirection = default(Vector2);
			WindStrength = 0f;
			WindSpeed = 0f;
			Turbulence = 0f;
		}

		public WindSettings(Vector2 gustDirection, float windStrength, float windSpeed, float turbulence)
		{
			WindDirection = default(Vector2);
			WindStrength = 0f;
			WindSpeed = 0f;
			Turbulence = 0f;
		}

		public void Apply(Texture2D gustNoise)
		{
		}

		public void Apply()
		{
		}

		public void ApplyToWindZone(WindZone zone)
		{
		}
	}
}
