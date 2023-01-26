//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
	public class ButtonEffect : MonoBehaviour
	{
        public GameObject handle;
        public void OnButtonDown(Hand fromHand)
		{
			Debug.Log("Кнопка нажата");
            setHandlePosition();
			// fromHand.TriggerHapticPulse(1000);
		}

		private void setHandlePosition()
		{	
			handle.transform.SetLocalPositionAndRotation(new Vector3(handle.transform.localPosition.x, handle.transform.localPosition.y, (float)0.2), handle.transform.localRotation);
        }
	}
}