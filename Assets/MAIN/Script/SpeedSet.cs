using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSet : MonoBehaviour
{
    public GameObject sppedIndicator;
    public GameObject speedHandle;
	public float speed;
    private float acceptable = 100000;
    private float f = 2.80599f;
    void Update()
	{
		speed = (speedHandle.transform.position.z - (float)1.5) * 80 / (float)0.4 + 20;

		if (speed < 0)
		{
			speed = 0;
		}

		if (CompareTag("rock hor"))
		{
            transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x - speed / acceptable, transform.localPosition.y, transform.localPosition.z), transform.localRotation);
        }
		else if (CompareTag("rock ver"))
		{
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y - speed / acceptable / f, transform.position.z), transform.rotation);
        }

        sppedIndicator.GetComponent<TextMesh>().text = "Скорость: " + (int)speed;
    }
}
