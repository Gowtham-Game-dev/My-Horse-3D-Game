
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class active : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="rock")
        {
           // Destroy(other.gameObject.FindComponent<BoxCollider>());
            StartCoroutine("death");
        }
    }
    IEnumerator death()
    {
       
        gameObject.GetComponent<WayPoint>().enabled = false;
        animator.SetTrigger("death");
        yield return new WaitForSeconds(5f);
        
        animator.SetTrigger("death2");
        yield return new WaitForSeconds(1f);
      
        animator.SetBool("run 0", true);
       
        gameObject.GetComponent<WayPoint>().enabled = true;

    }
}
