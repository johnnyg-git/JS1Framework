using AeLa.EasyFeedback.UI.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace AeLa.EasyFeedback.UI.Toaster
{
	[RequireComponent(typeof(RectTransform))]
	public class Toast : MonoBehaviour
	{
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected GameObject Text;

		private IText textComponent;

		public string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform RectTransform => null;

		private void Awake()
		{
		}
	}
}
