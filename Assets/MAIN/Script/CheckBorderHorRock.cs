using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckBorderHorRock : MonoBehaviour
{
    void Update()
    {
        if (transform.localPosition.x <= -0.42) // ����� �����_1 ��������� ���� �����
        {
            gameObject.SetActive(false);
        }
    }
}
