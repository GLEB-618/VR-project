using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckBorderRock : MonoBehaviour
{
    void Update()
    {
        if (transform.localPosition.x <= -0.42 && tag == "rock hor") // ����� �����_1 ��������� ���� �����
        {
            Destroy(gameObject);
        }
        if (transform.position.y <= 11.06405 && tag == "rock ver")
        {
            Destroy(gameObject);
        }
    }
}
