using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlace : MonoBehaviour
{
    public GameObject canvas;
    public GameObject first;
    public GameObject second;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
          
           second.SetActive(true);
            canvas.SetActive(true);
            first.SetActive(true);
            first.GetComponent<Text>().text = "1st Place : You";
        }
    }
}
