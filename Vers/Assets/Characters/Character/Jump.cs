using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Animator animator;
    Vector2 direction = new Vector2(0,1);
    Rigidbody2D jumper;
    public float jumpSpeed;
    public float FallAfterJump = 2f;
    bool animation_check = false;
    
    IEnumerator offParticle()
    {
        yield return new WaitForSeconds(0.2f);
       FallAfterJump= FallAfterJump+1.5f;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.tag == "DoubleJump")
        {
            jumper.AddForce(direction*jumpSpeed*3,ForceMode2D.Force);
            
            FallAfterJump= FallAfterJump-1.5f;
             StartCoroutine(offParticle());
        }
        
    }

   // private float falling = 0.02f;
    void Start()
    {
        jumper = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( IsGround && !pplatform && LockJump == false)
    { animation_check = false;}
    else{animation_check = true;}
        


        IsJump();


        PlatformCheck();

        GroundCheck();

        animator.SetBool("jump",animation_check);
        
    }

void OnLanding ()
{
    animator.SetBool("jump",false);
}
   public bool IsGround= false ;
   public Transform groundCheck;
   public float RadiusGroundCheck = 0.5f;
   public LayerMask Ground;
    public LayerMask Platform;
    bool ground= false;
    bool platform= false;
    public bool pplatform= false;



    private bool LockJump = false;

    void UnLockCharge()
    {
        LockJump = false;
    }

    
    void IsJump()
    {
        if (Input.GetKey(KeyCode.Space) && IsGround && !pplatform && LockJump == false)
        {
            LockJump = true;
            Invoke("UnLockCharge", 0.7f);

            jumper.AddForce(direction * jumpSpeed,ForceMode2D.Impulse);
            IsGround = false ;
        }
       else if (Input.GetKey(KeyCode.Space) && pplatform && !IsGround && LockJump == false)
        {
            LockJump = true;
            Invoke("UnLockCharge", 0.7f);

            jumper.AddForce(direction * jumpSpeed, ForceMode2D.Impulse);
            pplatform = false;
        }
        if (jumper.velocity.y < 0)
        {
            jumper.velocity += Vector2.up * Physics2D.gravity.y * (FallAfterJump - 1) * Time.deltaTime;
        }
    }
    void GroundCheck()
    {


        IsGround = Physics2D.OverlapCircle(groundCheck.position, RadiusGroundCheck, Ground);
    }
    void PlatformCheck()
    {
        pplatform= Physics2D.OverlapCircle(groundCheck.position, RadiusGroundCheck, Platform);
    }

}
