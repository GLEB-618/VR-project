using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckBorderSubmarine : MonoBehaviour
{
	void Update()
	{
		if (transform.localPosition.y >= 0.3675) // ����� ���������_1 ��������� ���� ������
		{
			transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, (float)0.3675, transform.localPosition.z), transform.localRotation);
		}
		else if (transform.localPosition.y <= -0.365) // ����� ���������_1 ��������� ���� �����
		{
			transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, (float)-0.365, transform.localPosition.z), transform.localRotation);
		}
    }
}
