namespace ScheduleOne.AvatarFramework.Customization
{
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
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
