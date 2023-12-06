using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedcharecter = 0;
 
    public void NextCheracter()
    {
        characters[selectedcharecter].SetActive(false);
        selectedcharecter=(selectedcharecter+1)%characters.Length;
        characters[selectedcharecter].SetActive(true);
       
    }
    public void previousCheracter()
    {
        characters[selectedcharecter].SetActive(false) ;
        selectedcharecter--;
        if(selectedcharecter<0)
        {
            selectedcharecter+=characters.Length;
        }
        characters[selectedcharecter].SetActive(true) ;
       
    }
    public void StartGame()
    {
      
        PlayerPrefs.SetInt("selectedCharacter", selectedcharecter);
        //SceneManager.LoadScene(1, LoadSceneMode.Single);
        SceneManager.LoadScene("Race");
    }
}
