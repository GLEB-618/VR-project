using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUpDawn : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Submarine")
        {
            foreach (Transform child in transform.parent.parent.parent.GetChild(1).GetChild(1).transform)
            {
                if (child.name == transform.parent.name)
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
    }
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "Submarine")
    //    {
    //        foreach (Transform child in transform.parent.parent.parent.GetChild(1).GetChild(1).transform)
    //        {
    //            if (child.name == transform.parent.name)
    //            {
    //                child.gameObject.SetActive(true);
    //            }
    //        }
    //    }
    //}
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Submarine")
        {
            foreach (Transform child in transform.parent.parent.parent.GetChild(1).GetChild(1).transform)
            {
                if (child.name == transform.parent.name)
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
    }
}
