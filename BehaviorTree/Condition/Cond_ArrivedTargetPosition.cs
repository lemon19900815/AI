using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BTEngine
{
	public class Cond_ArrivedTargetPosition : BTNManager.Precondition
	{
		public Cond_ArrivedTargetPosition()
		{
			int id = (int)ExtraInfo.eConditionID.Cond_ID_Arrived_TargetPosition;
			ExtraInfo.Instance.register(-id, this);
		}
		
		public override bool isTrue(InputParameter _input, OutputParameter _output)
		{
			if(_input.mSelf.curState == AIState.AI_State_MoveTo) {
				float distance = Vector3.Distance(_input.mSelf.movetoTargetPosition, _input.mSelf.getActorPosition());
				return distance <= 0.5f; // 在0.5码范围内，都算作到达目标点
			}

			return false;
		}
	}
}
