

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly_Patrol : MonoBehaviour
{
    Animator animator_fly;
    public float speedEnemy;
    public Transform fly_Point;
    public int positionEnemy;
    public Transform point;
    bool moveingRight;
    Transform player;
    public float stopingDistance;
    bool chill = false;
    bool angry = false;
    bool refreshPosition = false;
    private float timeInSec = 10f;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag=="Enemy Point")
        {
            refreshPosition = false;
            chill = true;
        }

        
    }

    

    void Start()
    {
        animator_fly= GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Playerr").transform;
        
        Chill();
    }

    // Update is called once per frame
    void Update()
    {
       animator_fly.SetBool("angry",angry);
        if (Vector2.Distance(transform.position, point.position) < positionEnemy && angry == false && refreshPosition ==false) // chill
        {
            chill = true;
        }
        if (Vector2.Distance(transform.position, player.position) < stopingDistance) //angry
        {
            angry = true;
            chill = false;
            refreshPosition = false;
        }
        if (Vector2.Distance(transform.position, player.position) > stopingDistance ) //refrsh position
        {
            refreshPosition = true;

            angry = false;
            
        }
        if (chill == true )
        {
            Chill();
        }
        else if (angry == true)
        {
            Angry();
        }
        else if (refreshPosition == true )
        {
            Return_Fly_Position();  
        }
       

    }
 

        void Chill()
    {
        if (transform.position.x > point.position.x + positionEnemy)
        {
            moveingRight = false;
        }
        else if (transform.position.x < point.position.x - positionEnemy)
        {
            moveingRight = true;
        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speedEnemy * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speedEnemy * Time.deltaTime, transform.position.y);
        }
        
    }
    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, (speedEnemy * 1.2f) * Time.deltaTime);

    }


    void Return_Fly_Position()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speedEnemy * Time.deltaTime);
       
    }
}

