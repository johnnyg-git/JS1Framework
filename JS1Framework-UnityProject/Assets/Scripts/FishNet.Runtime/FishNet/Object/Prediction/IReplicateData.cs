namespace FishNet.Object.Prediction
{
	public interface IReplicateData
	{
		uint GetTick();

		void SetTick(uint value);

		void Dispose();
	}
}
