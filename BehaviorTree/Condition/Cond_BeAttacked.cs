using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BTEngine
{
	public class Cond_BeAttacked : BTNManager.Precondition
	{
		public Cond_BeAttacked()
		{
			int id = (int)ExtraInfo.eConditionID.Cond_ID_BeAttacked;
			ExtraInfo.Instance.register(-id, this);
		}
		
		public override bool isTrue(InputParameter _input, OutputParameter _output)
		{
			float delta = Time.time - _input.mSelf.beAttackedTime;
			return delta <= 0.1f;
		}
	}
}
