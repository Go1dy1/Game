using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patrol : MonoBehaviour
{
    Animator animator_ground;
    public float speedEnemy;
    public int positionEnemy;
    public Transform point;
    bool moveingRight;
    Transform player;
    public float stopingDistance;
    bool chill= false;
    bool angry =false;
    bool refreshPosition = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag=="Enemy Point")
        {
            refreshPosition = false;
            chill = true;
        }
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("SampleScene");

        }


    }

    void Start()
    {
        animator_ground= GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Playerr").transform;
        Chill();
    }

    // Update is called once per frame
    void Update()
    {
        animator_ground.SetBool("angry",angry);
        if (Vector2.Distance(transform.position, point.position)< positionEnemy&& angry == false)
        {
           chill = true;
        }
        if (Vector2.Distance(transform.position, player.position)< stopingDistance)
        {
            angry = true;
            chill = false;
            refreshPosition = false;
        }
        if (Vector2.Distance(transform.position, player.position) > stopingDistance )
        {
            refreshPosition = true;
            angry = false;
           
            
        }
        if (chill == true)
        { Chill();}
       else if (angry == true)
        { Angry();}
        else if (refreshPosition == true)
        { RefreshPosition();}
        
    }
    void Chill()
    {
        if (transform.position.x > point.position.x + positionEnemy)
        { moveingRight = false;}
        else if (transform.position.x < point.position.x - positionEnemy)
        { moveingRight = true;}
        
        if (moveingRight)
        {transform.position = new Vector2(transform.position.x + speedEnemy * Time.deltaTime, transform.position.y);}
        else
        { transform.position = new Vector2(transform.position.x - speedEnemy * Time.deltaTime, transform.position.y);}
    }
    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, (speedEnemy*1.2f)* Time.deltaTime);
    
    }
    void RefreshPosition()
    {
transform.position = Vector2.MoveTowards(transform.position, point.position, speedEnemy * Time.deltaTime);    }

    
}
