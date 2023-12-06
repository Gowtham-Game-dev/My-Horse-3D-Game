using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraangle : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1)) { camera1.SetActive(true); maincamera.SetActive(false); }
        else camera1.SetActive(false); maincamera.SetActive(true);
        if (Input.GetKey(KeyCode.Alpha2)) { camera2.SetActive(true); maincamera.SetActive(false); }
        else camera2.SetActive(false); maincamera.SetActive(true);
        if (Input.GetKey(KeyCode.Alpha3)) { camera3.SetActive(true); maincamera.SetActive(false); }
        else camera3.SetActive(false); maincamera.SetActive(true);
        if (Input.GetKey(KeyCode.Alpha4)) { camera4.SetActive(true); maincamera.SetActive(false); }
        else camera4.SetActive(false); maincamera.SetActive(true);
    }
}
