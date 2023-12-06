using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPoint : MonoBehaviour
{
    

    public Transform[] waypoints;
    public float speed = 1f;
    private int currentWaypoint = 0;
    Animator animator;
    Rigidbody rb;
    public bool isground;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public float maxspeed=12f;

    private void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
      
    }

    void Update()
    {
        
        if (currentWaypoint < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);
            if(speed< maxspeed) { speed += 1f * Time.deltaTime; }
           if(speed>0)
            {
               
                animator.SetBool("run 0",true);
            }
            // Calculate the direction to the next waypoint
            Vector3 direction = waypoints[currentWaypoint].position - transform.position;
            direction.y = 0; // Set the y-component to zero to prevent the player from tilting

            if (direction != Vector3.zero)
            {
                // Rotate the player to face the next waypoint
                transform.rotation = Quaternion.LookRotation(direction);
            }

            if (transform.position == waypoints[currentWaypoint].position)
            {
                currentWaypoint++;
            }
            
        }
        if(speed> 0f&&isground)
        {
            part1.SetActive(true);
            part2.SetActive(true);
            part3.SetActive(true);
            part4.SetActive(true);

        }
        if (!isground)
        {
            animator.SetBool("run 0", false);
            part1.SetActive(false);
            part2.SetActive(false);
            part3.SetActive(false);
            part4.SetActive(false);
        }

        if (currentWaypoint == waypoints.Length)
        {

            animator.SetBool("run 0", false);
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "barrel")
        {
            
            speed = 3;
            animator.SetTrigger("jump");
            rb.AddForce(Vector3.up * 3, ForceMode.Impulse);
            isground=false;
        }
 
        if(other.tag=="Increase")
        {
            speed += 1f;
            maxspeed= 12;
            StartCoroutine("duration");
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isground = true;
        }
       

    }
    IEnumerator duration()
    {
        yield return new WaitForSeconds(3);
        speed=maxspeed;
    }

}

