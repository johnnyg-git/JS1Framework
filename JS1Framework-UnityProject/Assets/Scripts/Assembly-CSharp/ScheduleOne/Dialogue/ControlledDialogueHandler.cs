using System.Collections.Generic;

namespace ScheduleOne.Dialogue
{
	public class ControlledDialogueHandler : DialogueHandler
	{
		private DialogueController controller;

		protected override void Awake()
		{
		}

		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		protected override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}
	}
}
