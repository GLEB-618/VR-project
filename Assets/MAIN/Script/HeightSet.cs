using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightSet : MonoBehaviour
{
    public GameObject submarine;
    public GameObject heightIndicator;
    public float height = 0;
    void Update()
    {
        if (transform.position.z > 1.7)
        {
            height = (transform.position.z - (float)1.7) * 2 / (float)0.2;
        }
        else if (transform.localPosition.z < 1.7)
        {
            height = (transform.position.z - (float)1.7) * 2 / (float)0.2 - (float)0.2;
        }

        submarine.transform.SetLocalPositionAndRotation(new Vector3(submarine.transform.localPosition.x, submarine.transform.localPosition.y + height / 2000, submarine.transform.localPosition.z), submarine.transform.localRotation);

        heightIndicator.GetComponent<TextMesh>().text = "Высота: " + (int)-(100 - (submarine.transform.localPosition.y + 0.365) * 100 / 0.7325);
    }
}
