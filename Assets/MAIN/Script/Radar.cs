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
	public GameObject submarine2;
	public GameObject sppedIndicator;
	public GameObject heightIndicator;
	public GameObject rotationIndicator;
	public GameObject speedHandle;
	public GameObject heightHandle;
	public GameObject wheel;
    public GameObject radarRotation;
    public float speed = 30;
	public float height = 0;
	private float acceptable = 100000;
	private float f = 1.82575f;
	public float rotation = 0;
	public float rr = 0;
	public void Update()
	{
		speed = (speedHandle.transform.position.z - (float)1.5) * 80 / (float)0.4 + 20;
        if (speed < 0)
        {
            speed = 0;
        }
        rotation = wheel.transform.localRotation.z * 90 / (float)0.7071068;

        if (submarine.transform.localPosition.y >= 0.3675) // ����� ���������_1 ��������� ���� ������
		{
			submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, (float)0.3675, submarine.transform.localPosition.z), submarine.transform.localRotation);
		}
		else if (submarine.transform.localPosition.y <= -0.365) // ����� ���������_1 ��������� ���� �����
		{
			submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, (float)-0.365, submarine.transform.localPosition.z), submarine.transform.localRotation);
		}
		if (rock.transform.localPosition.x <= -0.42) // ����� �����_1 ��������� ���� ������
		{
			rock.transform.SetLocalPositionAndRotation(new Vector3(rock.transform.position.x, rock.transform.localPosition.y, 10), rock.transform.localRotation);
		}
		if (rock2.transform.position.y <= 11.06405) // ����� �����_2 ��������� ���� �����
		{
			rock.transform.SetLocalPositionAndRotation(new Vector3((float)0.41, rock.transform.localPosition.y, (float)-0.499), rock.transform.localRotation);
			rock2.transform.SetPositionAndRotation(new Vector3(1, (float)11.69, rock2.transform.position.z), rock2.transform.rotation);
			radarRotation.transform.Rotate(0, 0, 0, Space.World);
			rr = 0;
		}
        if (submarine.transform.localPosition.y >= -0.015) // ����� ���������_1 ���� �����_1
		{
			rock2.transform.SetLocalPositionAndRotation(new Vector3(rock2.transform.localPosition.x, rock2.transform.localPosition.y, 10), rock2.transform.localRotation);
		}
		else
		{
			rock2.transform.SetLocalPositionAndRotation(new Vector3(rock2.transform.localPosition.x, rock2.transform.localPosition.y, (float)-0.499), rock2.transform.localRotation);
		}
		if (heightHandle.transform.position.z > 1.7)
		{
			height = (heightHandle.transform.position.z - (float)1.7) * 2 / (float)0.2;
		}
		else if (heightHandle.transform.localPosition.z < 1.7)
		{
			height = (heightHandle.transform.position.z - (float)1.7) * 2 / (float)0.2 - (float)0.2;
		}

		if ((int)rotation != 0) {
            rr -= wheel.transform.localRotation.z * 90 * 0.001f;
        }

		Debug.Log(wheel.transform.localRotation.z);

        rock.transform.SetLocalPositionAndRotation(new Vector3(rock.transform.localPosition.x - speed / acceptable, rock.transform.localPosition.y, rock.transform.localPosition.z), rock.transform.localRotation);
		submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, submarine.transform.localPosition.y + height / 2000, submarine.transform.localPosition.z), submarine.transform.localRotation);
		//rock2.transform.SetLocalPositionAndRotation(new Vector3(rock2.transform.localPosition.x, rock2.transform.localPosition.y - speed / (f * acceptable), rock2.transform.localPosition.z), rock2.transform.localRotation);
        rock2.transform.SetPositionAndRotation(new Vector3(rock2.transform.position.x, rock2.transform.position.y - speed / (f * acceptable), rock2.transform.position.z), rock2.transform.rotation);
        radarRotation.transform.SetLocalPositionAndRotation(radarRotation.transform.localPosition, Quaternion.Euler(new Vector3(0, 0, rr)));

        sppedIndicator.GetComponent<TextMesh>().text = "��������: " + (int)speed;
		heightIndicator.GetComponent<TextMesh>().text = "������: " + (int)-(100 - (submarine.transform.localPosition.y + 0.365) * 100 / 0.7325);
		rotationIndicator.GetComponent<TextMesh>().text = "�������: " + (int)rotation;
	}
}
