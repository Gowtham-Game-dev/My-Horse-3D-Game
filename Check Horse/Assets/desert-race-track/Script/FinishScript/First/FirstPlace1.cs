using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlace1 : MonoBehaviour
{
    public GameObject canvas;
    public GameObject firstPlayer1;
    public GameObject second;

   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            
            second.SetActive(true);
            canvas.SetActive(true);
            firstPlayer1.SetActive(true);
            firstPlayer1.GetComponent<Text>().text = "1st Place  : VetrriMaran";
        }
    }
}
