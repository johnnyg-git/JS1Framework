using System.Collections.Generic;
using UnityEngine;

namespace AmplifyImpostors
{
	[CreateAssetMenu(fileName = "New Impostor", order = 85)]
	public class AmplifyImpostorAsset : ScriptableObject
	{
		[SerializeField]
		public Material Material;

		[SerializeField]
		public Mesh Mesh;

		[HideInInspector]
		[SerializeField]
		public int Version;

		[SerializeField]
		public ImpostorType ImpostorType;

		[HideInInspector]
		[SerializeField]
		public bool LockedSizes;

		[HideInInspector]
		[SerializeField]
		public int SelectedSize;

		[SerializeField]
		public Vector2 TexSize;

		[HideInInspector]
		[SerializeField]
		public bool DecoupleAxisFrames;

		[SerializeField]
		[Range(1f, 32f)]
		public int HorizontalFrames;

		[SerializeField]
		[Range(1f, 33f)]
		public int VerticalFrames;

		[SerializeField]
		[Range(0f, 64f)]
		public int PixelPadding;

		[SerializeField]
		[Range(4f, 16f)]
		public int MaxVertices;

		[SerializeField]
		[Range(0f, 0.2f)]
		public float Tolerance;

		[SerializeField]
		[Range(0f, 1f)]
		public float NormalScale;

		[SerializeField]
		public Vector2[] ShapePoints;

		[SerializeField]
		public AmplifyImpostorBakePreset Preset;

		[SerializeField]
		public List<TextureOutput> OverrideOutput;
	}
}
