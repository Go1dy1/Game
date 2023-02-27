using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Saw_Damage : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float speed_Saw;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Playerr")
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        }
        if(collision.tag=="Point1"){
            range1=false;
            range2= true;
        }
        if(collision.tag=="Point2"){
            range2=false;
            range1=true;
        }

    }
 void Start()
{
    Point1Range_Saw();
}
    void Update()
    {
        

       if(range1 ==true){
        Point1Range_Saw();
       }
       if(range2 ==true){
        Point2Range_Saw();
       }
    }
    public void Point1Range_Saw(){
         transform.position = Vector2.MoveTowards(transform.position, point1.position, speed_Saw * Time.deltaTime);
    } 
public void Point2Range_Saw(){
         transform.position = Vector2.MoveTowards(transform.position, point2.position, speed_Saw * Time.deltaTime);
    } 
bool range1= false;
bool range2= false;
}


