using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRock : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        spawn();
    }
    public void spawn()
    {
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.Alpha4))
        {
            GameObject instantiatedObject = Instantiate(prefab, transform.position, transform.rotation);

            Destroy(instantiatedObject, 3f);
        }
    }
}
