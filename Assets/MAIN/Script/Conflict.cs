using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conflict : MonoBehaviour
{

	public GameObject light;

	public void OnTriggerEnter2D(Collider2D collision)
	{
        // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "rock hor" || collision.gameObject.tag == "rock ver")
		{
			// Debug.Log(collision.gameObject.tag + " X: " + collision.transform.localPosition.x + " Y: " + collision.transform.localPosition.y);
			// SceneManager.LoadScene("Conflict");
		}
		if (collision.gameObject.name == "Alarm")
		{
			light.SetActive(true);
		}
	}
	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.name == "Alarm")
		{
			light.SetActive(false);
		} 
    }
}
