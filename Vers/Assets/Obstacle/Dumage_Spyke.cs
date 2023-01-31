using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dumage_Spyke : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Playerr")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    public void Update()
    {
      
    }
    
    

}
