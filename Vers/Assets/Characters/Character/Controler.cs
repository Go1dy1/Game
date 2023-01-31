using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour

{
    public Animator animator;
    Rigidbody2D m_rigboddy2D;

   public float m_Speed = 10f;
    Vector2 m_vector2;
    void Start()
    {
        m_rigboddy2D = GetComponent<Rigidbody2D>();

        
    }


   
    void FixedUpdate()
    {
        Vector3 v3Velocity =m_rigboddy2D.velocity;
        var speed = m_rigboddy2D.velocity.magnitude;
      Walk();
        if (Input.GetKey(KeyCode.D))
        {
            m_rigboddy2D.transform.localScale = new Vector3 (1,1,1);
        }
        animator.SetFloat("speed",Mathf.Abs(speed));
        if (Input.GetKey(KeyCode.A))
        {
            m_rigboddy2D.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void Walk()
    {
        m_vector2.x = Input.GetAxis("Horizontal");
        m_rigboddy2D.velocity = new Vector2 (m_vector2.x* m_Speed,m_rigboddy2D.velocity.y );
    }
}
