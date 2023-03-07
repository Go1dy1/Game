using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prototype_Saw : MonoBehaviour
{
  public Transform point1;
    public Transform point2;
    public float speed_Saw;

    private bool moveTowardsPoint1 = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Playerr")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    private void Update()
    {
        if (moveTowardsPoint1)
        {
            transform.position = Vector2.MoveTowards(transform.position, point1.position, speed_Saw * Time.deltaTime);
            if (Vector2.Distance(transform.position, point1.position) < 0.01f)
            {
                moveTowardsPoint1 = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, point2.position, speed_Saw * Time.deltaTime);
            if (Vector2.Distance(transform.position, point2.position) < 0.01f)
            {
                moveTowardsPoint1 = true;
            }
        }
    }
}
