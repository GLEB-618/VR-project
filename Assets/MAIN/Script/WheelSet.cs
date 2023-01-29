using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WheelSet : MonoBehaviour
{
    public GameObject rotationIndicator;
    public GameObject radarRotation;
    private float rotation;
    private float rr = 0;

    void Update()
    {
        rotation = transform.localRotation.z * 90 / (float)0.7071068;

        if ((int)rotation != 0)
        {
            rr -= transform.localRotation.z * 90 * 0.001f;
        }

        radarRotation.transform.SetLocalPositionAndRotation(radarRotation.transform.localPosition, Quaternion.Euler(new Vector3(0, 0, rr)));

        rotationIndicator.GetComponent<TextMesh>().text = "Поворот: " + (int)rotation;
    }
}
