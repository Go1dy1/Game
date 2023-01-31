using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public Transform target;
    public float smooth= 5.0f;
    public GameObject player; // тут объект игрока
    private Vector3 offset;  

    void Start () 
    {        
        offset = transform.position - player.transform.position;
    }

    void LateUpdate () 
    {        
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void  Update (){
    transform.position = Vector3.Lerp (transform.position, target.position + offset, Time.deltaTime * smooth);
} 
}
