using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStopLift : MonoBehaviour
{
    public GameObject button;
    public GameObject heightHandle;

    public void InputButton()
    {
        button.transform.SetLocalPositionAndRotation(new Vector3(button.transform.localPosition.x, button.transform.localPosition.y - (float)0.03, button.transform.localPosition.z), button.transform.localRotation);
        heightHandle.transform.SetLocalPositionAndRotation(new Vector3(heightHandle.transform.localPosition.x, (float)3.576279e-07, heightHandle.transform.localPosition.z), heightHandle.transform.localRotation);
    }
}
