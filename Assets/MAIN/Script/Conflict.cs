using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conflict : MonoBehaviour
{
	public void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.name == "Rock" || collision.gameObject.name == "Rock_2")
        {
            SceneManager.LoadScene("Conflict");
        }
    }
}
