using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadPlayer : MonoBehaviour
{
    public GameObject[] playerprefabs;
    public Transform spawnPoint;
   
    void Start()
    {
        int selectedplayer = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = playerprefabs[selectedplayer];
        GameObject clone=Instantiate(prefab,spawnPoint.position,transform.rotation);
      
    }

    
}
