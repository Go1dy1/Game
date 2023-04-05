using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class rigbody : MonoBehaviour
{ 
    public float speedEnemy;
    public Transform trinagle;
    public Transform dot;
    public Transform dot1;
    Tween tween;
    
    void switchBoolfalse(){
       checkJump =false;
        
    }
    void switchBooltrue(){
       checkJump =true;
        
    }

    bool checkJump= true;

    
    void Start()
    {
      Invoke("Jumper", 4f); 
      Invoke("switchBoolfalse", 4f);
      Invoke("switchBooltrue", 5.5f);
      Invoke("Jumper2", 6.5f); 
      Invoke("switchBoolfalse", 6.5f);
      Invoke("switchBooltrue", 7f);
    }

    // Update is called once per frame
    void Update()
    {
     if(checkJump== true ){
        
        MoveWheel();

         }
    }
    void Jumper2()
{transform.DOJump(dot1.position,3f,1,2f,false);}
void MoveWheel()
{
  transform.position= Vector2.MoveTowards(transform.position,trinagle.position,speedEnemy * Time.deltaTime); 
}
  
void Jumper()
{transform.DOJump(dot.position,3f,2,2f,false);}

}

