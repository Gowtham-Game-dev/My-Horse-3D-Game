using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countown : MonoBehaviour
{
    public GameObject countown;
   
   
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(countownstart());
    }

   
  
    IEnumerator countownstart()
    {
        yield return new WaitForSeconds(0.5f);
        countown.GetComponent<Text>().text = "3";
        countown.SetActive(true);

        yield return new WaitForSeconds(1f);
        countown.SetActive(false);
        countown.GetComponent<Text>().text = "2";
        countown.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        countown.SetActive(false);
        countown.GetComponent<Text>().text = "1";
        countown.SetActive(true);

        yield return new WaitForSeconds(2f);
        countown.SetActive(false);
        countown.GetComponent<Text>().text = "Go";
        countown.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        countown.SetActive(false);

        

        GameObject.Find("Player(Clone)").GetComponent<Movement>().enabled = true;
        GameObject.Find("ArabianHorseJockey 7").GetComponent<WayPoint>().enabled = true;
        GameObject.Find("ArabianHorseJockey 10").GetComponent<WayPoint>().enabled = true;
        GameObject.Find("ArabianHorseJockey 5").GetComponent<WayPoint>().enabled = true;
        GameObject.Find("ArabianHorseJockey 2").GetComponent<WayPoint>().enabled = true;
    }
}
