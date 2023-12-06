using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI    ;

public class FirstPlace4 : MonoBehaviour
{
    public GameObject canvas;
    public GameObject firstPlayer4;
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
        if (other.tag == "Player4")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            second.SetActive(true);
            canvas.SetActive(true);
            firstPlayer4.SetActive(true);
            firstPlayer4.GetComponent<Text>().text = "1st Place  : "+other.name;
        }
    }
}
