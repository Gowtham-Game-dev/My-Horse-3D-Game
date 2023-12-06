using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroOkButton : MonoBehaviour
{
    public GameObject Instruction;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Introstart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Introstart()
    {
        yield return new WaitForSeconds(3);
        Instruction.SetActive(true);
    }
    public void OkButton()
    {
        SceneManager.LoadScene("Avatar");
    }
}
