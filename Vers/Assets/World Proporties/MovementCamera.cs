using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
   public Transform player;
   public Transform Camera;
public float speed_Camera =0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position!=Camera.position){
        Method();
        }
    }
 void Method()
{
transform.position = Vector3.MoveTowards(transform.position,player.position,speed_Camera* Time.deltaTime);
}

}
