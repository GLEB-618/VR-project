using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSet : MonoBehaviour
{
	public GameObject sppedIndicator;
	public float speed;
	void Update()
	{
		speed = (transform.position.z - (float)1.5) * 80 / (float)0.4 + 20;

		sppedIndicator.GetComponent<TextMesh>().text = "Скорость: " + (int)speed;
	}
}
