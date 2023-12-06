using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlace3 : MonoBehaviour
{

    public GameObject canvas;
    public GameObject firstPlayer3;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player3")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            second.SetActive(true);
            canvas.SetActive(true);
            firstPlayer3.SetActive(true);
            firstPlayer3.GetComponent<Text>().text = "1st Place  : Dhanush";
        }
    }
}
