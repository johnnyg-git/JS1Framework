namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		public override void CallValueChange()
		{
		}

		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}
	}
}
