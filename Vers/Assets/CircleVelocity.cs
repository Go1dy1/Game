using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleVelocity : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        StartCoroutine(BallCoroutine());
         
    }
IEnumerator BallCoroutine() {
    while (true) {
        rb.velocity= new Vector2(4.5f,0.2f);
        yield return new WaitForSeconds(15f);
    }
}
    // Update is called once per frame
    void FixUpdate()
    {
       
    }
}
