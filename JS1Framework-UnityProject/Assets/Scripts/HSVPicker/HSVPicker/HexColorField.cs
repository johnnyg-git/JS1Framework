using TMPro;
using UnityEngine;

namespace HSVPicker
{
	[RequireComponent(typeof(TMP_InputField))]
	[DefaultExecutionOrder(10)]
	public class HexColorField : MonoBehaviour
	{
		public ColorPicker hsvpicker;

		public bool displayAlpha;

		private TMP_InputField hexInputField;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateHex(Color newColor)
		{
		}

		private void UpdateColor(string newHex)
		{
		}

		private string ColorToHex(Color32 color)
		{
			return null;
		}
	}
}
