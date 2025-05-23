using UnityEngine.Events;

namespace AeLa.EasyFeedback.UI.Interfaces
{
	public interface IInputField
	{
		UnityEvent<string> OnValueChanged { get; }

		string Text { get; set; }

		bool IsFocused { get; }

		void ActivateInputField();

		void DeactivateInputField();
	}
}
