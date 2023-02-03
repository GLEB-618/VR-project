using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRock : MonoBehaviour
{
    public GameObject[] rocks;
    private GameObject rock;
    public Transform rockSpawn;

    void Start() // , new Vector3(rocks[i].transform.position.x, rand, rocks[i].transform.position.z), Quaternion.identity
    {
        Spawn();
    }
    public void StartSpawn(int x)
    {
        Spawn(x);
    }
    private void Spawn(int x = -1)
    {
        int c = 0;
        for (int i = 0; i < rocks.Length; i++)
        {
            if (c == x || x == -1)
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
                    foreach (Transform child in transform.GetChild(1).GetChild(1).transform)
                    {
                        if (child.tag == "spawn")
                        {
                            rock.transform.SetLocalPositionAndRotation(new Vector3(child.transform.localPosition.x, child.transform.localPosition.y, child.transform.localPosition.z), Quaternion.identity);
                        }
                    }
                    rock.name = "rock " + c;
                    // rock.SetActive(false);
                    c++;
                }
            }
        }
    }
}