using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	public class NumberVariable : Variable<float>
	{
		public NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value)
			: base((string)null, default(EVariableReplicationMode), persistent: false, default(EVariableMode), (Player)null, 0f)
		{
		}//IL_0024: Expected F4, but got O


		public override bool TryDeserialize(string valueString, out float value)
		{
			value = default(float);
			return false;
		}

		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return false;
		}
	}
}
