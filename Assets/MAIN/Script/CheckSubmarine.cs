using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckSubmarine : MonoBehaviour
{
	void Update()
	{
		if (transform.localPosition.y >= 0.3675) // Когда субмарина_1 достигает края сверху
		{
			transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, (float)0.3675, transform.localPosition.z), transform.localRotation);
		}
		else if (transform.localPosition.y <= -0.365) // Когда субмарина_1 достигает края снизу
		{
			transform.SetLocalPositionAndRotation(new Vector3(transform.localPosition.x, (float)-0.365, transform.localPosition.z), transform.localRotation);
		}
    }
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "UpDawn")
    //    {
    //        foreach (Transform child in transform.parent.parent.GetChild(1).GetChild(1).transform)
    //        {
    //            if (child.name == collision.transform.parent.name)
    //            {
    //                child.gameObject.SetActive(true);
    //            }
    //        }
    //    }
    //}
    //public void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "UpDawn")
    //    {
    //        foreach (Transform child in transform.parent.parent.GetChild(1).GetChild(1).transform)
    //        {
    //            if (child.name == collision.transform.parent.name)
    //            {
    //                child.gameObject.SetActive(false);
    //            }
    //        }
    //    }
    //}
    //public void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.name == "UpDawn")
    //    {
    //        foreach (Transform child in transform.parent.parent.GetChild(1).GetChild(1).transform)
    //        {
    //            if (child.name == collision.transform.parent.name)
    //            {
    //                child.gameObject.SetActive(true);
    //            }
    //        }
    //    }
    //    else
    //    {
    //        foreach (Transform child in transform.parent.parent.GetChild(1).GetChild(1).transform)
    //        {
    //            if (child.name == collision.transform.parent.name)
    //            {
    //                child.gameObject.SetActive(false);
    //            }
    //        }
    //    }
    //}
}
