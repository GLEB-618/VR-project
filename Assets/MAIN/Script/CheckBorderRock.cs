using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckBorderRock : MonoBehaviour
{
	void Update()
	{
		if (transform.localPosition.x <= -0.42 && tag == "rock hor") // Когда скала_1 достигает края слева
		{
			Destroy(gameObject);
		}
		if (transform.position.y <= 11.06405 && tag == "rock ver")
		{
            int x = Convert.ToInt32(gameObject.name.Substring(gameObject.name.Length - 1));
            Destroy(gameObject);
			SpawnRock beh = (SpawnRock)GameObject.Find("Radar").GetComponent(typeof(SpawnRock));
			beh.StartSpawn(x);
		}
	}
}
