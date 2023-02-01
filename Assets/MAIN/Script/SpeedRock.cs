using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRock : MonoBehaviour
{
	private float f = 2.79f; // 2.79f
    private float acceptable = 100000;
    public float speed;
	void Update()
	{
        SpeedSet beh = (SpeedSet)GameObject.Find("SpeedHandle").GetComponent(typeof(SpeedSet));
        speed = beh.speed;
        if (CompareTag("rock hor"))
        {
            transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x - speed / acceptable, transform.localPosition.y, transform.localPosition.z), transform.localRotation);
        }
        else if (CompareTag("rock ver"))
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y - speed / acceptable / f, transform.position.z), transform.rotation);
        }
    }
}
