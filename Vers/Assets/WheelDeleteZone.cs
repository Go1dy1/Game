using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelDeleteZone : MonoBehaviour
{
   
     public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Gear")
        {
          Destroy(collision.gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
