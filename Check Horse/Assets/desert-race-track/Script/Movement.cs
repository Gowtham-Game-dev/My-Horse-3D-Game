using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Animator animator;
    public float speed=0;
    public float maxspeed=8;
    Rigidbody rb;
    public bool isground;
    public bool issand;
    private float horizontalInput;
    private float verticalInput;
    public GameObject Bcollider;
    public GameObject Bcollider1;
    
    public float boost;
    public float cooldown;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public AudioClip audioClip;
    public AudioClip JumpaudioClip;
    public GameObject line;

    private GameObject Endsound;
    private GameObject MidSound;


    private void Awake()
    {
       
       Endsound = GameObject.Find("EndSound");
        MidSound = GameObject.Find("MidSound");
    }

    void Start()
    {

        Endsound.SetActive(false);
       
        rb = GetComponent<Rigidbody>();
        animator=GetComponent<Animator>();

        Bcollider.SetActive(false);
        Bcollider1.SetActive(false);
    }


    void Update()
    {
        


         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");
        if (verticalInput>0)
        {
          
            transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
            animator.SetBool("walk", true);
            if (speed < maxspeed) { speed += 0.5f * Time.deltaTime; }

        }
  

            if (speed > 1)
        {
            animator.SetBool("run", true);
           
        }
            

        if (speed < 1)
        {
            
            animator.SetBool("run", false);
          
        }
        if(verticalInput == 0)
        {
            
            animator.SetBool("walk", false);
            speed = 0;
        }


        if
            (Input.GetKey(KeyCode.Q))
        {
            animator.SetTrigger("fast");
        }

           transform.Rotate(Vector3.up *  0.002f * Time.deltaTime, horizontalInput);
        if (verticalInput <0)
        {
            animator.SetBool("back",true);
            animator.SetBool("walk", false);
            transform.Translate(Vector3.back * -verticalInput * 2 * Time.deltaTime);
        }else animator.SetBool("back", false);
        if (Input.GetKeyDown(KeyCode.Space)&&isground)  
        {
            AudioSource.PlayClipAtPoint(JumpaudioClip, transform.position);
            transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
            // speed = 5;
            rb.AddForce(Vector3.up*4,ForceMode.Impulse);
            animator.SetTrigger("jump");
            isground= false;
            issand = false;
        }
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Bcollider.SetActive(true);
            animator.SetBool("attack1", true);
        }else {animator.SetBool("attack1", false); Bcollider.SetActive(false);}
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Bcollider1.SetActive(true);
            animator.SetBool("attack2", true);
        } else {animator.SetBool("attack2", false); Bcollider1.SetActive(false);}
        if (issand == true && verticalInput > 0) { speed = 2; maxspeed = 2; animator.SetBool("walk", true); }
        

        if (speed > 0f && isground)
        {
            part1.SetActive(true);
            part2.SetActive(true);
            part3.SetActive(true);
            part3.SetActive(true);
        }
        if (! isground)
        {
            part1.SetActive(false);
            part2.SetActive(false);
            part3.SetActive(false);
            part4.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="ground")
        {
            issand = false;
            isground = true;
        } 
        if (collision.gameObject.tag == "sand")
        {
            isground= false;
            issand = true;
            
        }
  
       if (issand == false && verticalInput > 0 && isground == true) { maxspeed = 8; }

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="SoundTrigger")
        {
            
            Endsound.SetActive(true);
        }
        if (other.tag == "MidSound")
        {
            GameObject.Find("middlesound").GetComponent<AudioSource>().enabled = true;
           
        }
        if (other.tag == "Increase")
        {
            AudioSource.PlayClipAtPoint(audioClip,transform.position);
            speed += 1.5f;
            maxspeed=16;
            
            StartCoroutine("duration");
        }
        if(other.tag=="Finish")
        {
            
          GameObject.Find("Player(Clone)").GetComponent<Movement>().enabled= false;
            GameObject.Find("Player(Clone)").GetComponent<AudioSource>().enabled = false;
            // gameObject.FindComponent<Movement>().enabled = false;
            animator.SetBool("run",false);
            animator.SetBool("walk", false);
            line.SetActive(true);
        }
       
    }
    IEnumerator duration()
    {
        yield return new WaitForSeconds(cooldown);
        maxspeed= 13;
        speed =13;
       
    }




}
