using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conflict : MonoBehaviour
{
	public GameObject rock;
	public void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("��������� ������������");
        if (collision.gameObject.name == "Rock")
		{
			Debug.Log("��������� ������������ 2");
		}
	}
	public void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log("��������� ������������");
        if (collision.gameObject.name == "Rock")
        {
            Debug.Log("��������� ������������ 2");
        }
    }
}
