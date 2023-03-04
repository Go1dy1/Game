using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Finish : MonoBehaviour
{

    private float AllPotionsStart;
    void Start()
    {
       

    }
    void Update()
    {
        AllPotionsStart =GameObject.FindGameObjectsWithTag("Potion").Length;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (AllPotionsStart==0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        
    }
 
}
