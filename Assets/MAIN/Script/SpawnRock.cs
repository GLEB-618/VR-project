using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRock : MonoBehaviour
{
	public GameObject[] rocks;
	private GameObject rock;

	void Start() // , new Vector3(rocks[i].transform.position.x, rand, rocks[i].transform.position.z), Quaternion.identity
    {
		int c = 0;
		for (int i = 0; i < rocks.Length; i++)
		{
			if (i % 2 == 0)
			{
				float rand = Random.Range(-0.205f, 0.215f);
				rock = Instantiate(rocks[i]);
				rock.transform.parent = transform.GetChild(0);
				rock.transform.SetLocalPositionAndRotation(new Vector3(rocks[i].transform.localPosition.x, rand, rocks[i].transform.localPosition.z), Quaternion.identity);
				rock.name = "rock " + c;
			}
			else
			{
                // float rand = Random.Range(-0.205f, 0.215f);
				rock = Instantiate(rocks[i]);
				rock.transform.parent = transform.GetChild(1).GetChild(1);
                rock.transform.SetLocalPositionAndRotation(new Vector3(rocks[i].transform.localPosition.x, rocks[i].transform.localPosition.y, rocks[i].transform.localPosition.z), Quaternion.identity);
                rock.name = "rock " + c;
				// rock.SetActive(false);
				c++;
            }
		}
	}
}