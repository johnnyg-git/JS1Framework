namespace Funly.SkyStudio
{
	public class SkyBlender : FeatureBlender
	{
		protected override string featureKey => null;

		protected override ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper)
		{
			return default(ProfileFeatureBlendingMode);
		}

		protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
		}

		protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
		}
	}
}
