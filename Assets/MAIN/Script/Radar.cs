using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Radar : MonoBehaviour
{
	public GameObject rock;
	public GameObject submarine;
	public GameObject rock2;
    public Transform rock2Transform;
    public GameObject submarine2;
	// public GameObject sppedIndicator;
	// public GameObject heightIndicator;
	// public GameObject rotationIndicator;
	// public GameObject speedHandle;
	// public GameObject heightHandle;
	public GameObject wheel;
    // public GameObject radarRotation;
    // public float speed = 30;
	// public float height = 0;
	// private float acceptable = 100000;
	// private float f = 2.80599f;
	// public float rotation = 0;
	// private float rr = 0;
	public void Update()
	{
		//speed = (speedHandle.transform.position.z - (float)1.5) * 80 / (float)0.4 + 20;
  //      if (speed < 0)
  //      {
  //          speed = 0;
  //      }
        // rotation = wheel.transform.localRotation.z * 90 / (float)0.7071068;

  //      if (submarine.transform.localPosition.y >= 0.3675) // Когда субмарина_1 достигает края сверху
		//{
		//	submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, (float)0.3675, submarine.transform.localPosition.z), submarine.transform.localRotation);
		//}
		//else if (submarine.transform.localPosition.y <= -0.365) // Когда субмарина_1 достигает края снизу
		//{
		//	submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, (float)-0.365, submarine.transform.localPosition.z), submarine.transform.localRotation);
		//}
		//if (rock.transform.localPosition.x <= -0.42) // Когда скала_1 достигает края слева
		//{
		//	rock.SetActive(false);
		//}
		if (rock2.transform.position.y <= 11.06405) // Когда скала_2 достигает края снизу
		{
			rock.SetActive(true);
			rock.transform.SetLocalPositionAndRotation(new Vector3((float)0.41, rock.transform.localPosition.y, (float)-0.499), rock.transform.localRotation);
			rock2.transform.SetPositionAndRotation(rock2Transform.position, rock2.transform.rotation);
			//radarRotation.transform.rotation = Quaternion.identity; ДУМАТЬ ЧТО НАДО СДЕЛАТЬ!!!
			//rr = 0;
		}
        if (submarine.transform.localPosition.y >= -0.015) // Когда субмарина_1 выше скалы_1
		{
			rock2.SetActive(false);
		}
		else
		{
            rock2.SetActive(true);
        }

		//if (heightHandle.transform.position.z > 1.7)
		//{
		//	height = (heightHandle.transform.position.z - (float)1.7) * 2 / (float)0.2;
		//}
		//else if (heightHandle.transform.localPosition.z < 1.7)
		//{
		//	height = (heightHandle.transform.position.z - (float)1.7) * 2 / (float)0.2 - (float)0.2;
		//}

		//if ((int)rotation != 0) {
  //          rr -= wheel.transform.localRotation.z * 90 * 0.001f;
  //      }

        // rock.transform.SetLocalPositionAndRotation(new Vector3(rock.transform.localPosition.x - speed / acceptable, rock.transform.localPosition.y, rock.transform.localPosition.z), rock.transform.localRotation);
		// submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, submarine.transform.localPosition.y + height / 2000, submarine.transform.localPosition.z), submarine.transform.localRotation);
		// rock2.transform.SetPositionAndRotation(new Vector3(rock2.transform.position.x, rock2.transform.position.y - speed / acceptable / f, rock2.transform.position.z), rock2.transform.rotation);
        //radarRotation.transform.SetLocalPositionAndRotation(radarRotation.transform.localPosition, Quaternion.Euler(new Vector3(0, 0, rr)));

        // sppedIndicator.GetComponent<TextMesh>().text = "Скорость: " + (int)speed;
		// heightIndicator.GetComponent<TextMesh>().text = "Высота: " + (int)-(100 - (submarine.transform.localPosition.y + 0.365) * 100 / 0.7325);
		// rotationIndicator.GetComponent<TextMesh>().text = "Поворот: " + (int)rotation;
	}
}
