using System;
using UnityEngine;

namespace AmplifyColor
{
	[Serializable]
	public struct RenderLayer
	{
		public LayerMask mask;

		public Color color;

		public RenderLayer(LayerMask mask, Color color)
		{
			this.mask = default(LayerMask);
			this.color = default(Color);
		}
	}
}
