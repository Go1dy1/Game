using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pendulum : MonoBehaviour
{
    public Transform dot1;
    public Transform dot2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }


    void LeftPendulum(){
        transform.DOMoveX(1f,2f);
    }
    void RightPendulum(){
        transform.DOMoveX(-2,2f);
    }
}


