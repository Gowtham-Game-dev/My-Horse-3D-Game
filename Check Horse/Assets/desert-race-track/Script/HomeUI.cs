using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HomeButtton()
    {
        SceneManager.LoadScene("Avatar");
    }
    public void RestartButtton()
    {
        SceneManager.LoadScene("Race");
    }
    public void QuitButtton()
    {
       Application.Quit();
    }
}
