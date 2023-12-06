using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FirstPlace2 : MonoBehaviour
{
    public GameObject canvas;
    public GameObject firstPlayer2;
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
        if (other.tag == "Player2")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            second.SetActive(true);
            canvas.SetActive(true);
            firstPlayer2.SetActive(true);
            firstPlayer2.GetComponent<Text>().text = "1st Place  : Dhanush";
        }
    }
}
