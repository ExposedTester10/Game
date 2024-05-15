using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator PlayerAnim;
    [SerializeField] float speed = 20f;
    float movement;
    float acceleration;
    float rotation;
    float move;
    Quaternion W = Quaternion.Euler(0, 0, 0);
     Quaternion S = Quaternion.Euler(0, 0, 180);
      Quaternion A = Quaternion.Euler(0, 0, 90);
       Quaternion D = Quaternion.Euler(0, 0, -90);
        Quaternion WD = Quaternion.Euler(0, 0, -45);
         Quaternion WA = Quaternion.Euler(0, 0, 45);
          Quaternion SA = Quaternion.Euler(0, 0, 135);
           Quaternion SD = Quaternion.Euler(0, 0, -135);
    void Start()
    {
        rotation = -180;
    }
    
    void Update()
    {

        PlayerAnim.SetFloat("Rotation", rotation);
        PlayerAnim.SetFloat("Speed", move);

        movement = speed * acceleration * Time.deltaTime;
        transform.Translate(0, movement, 0);
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) 
        {
            acceleration = 1;
        } else 
        {
            acceleration = 0;
        }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = WD;
            rotation = -45;
            move = 1;
        } else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = WA;
            rotation = 45;
            move = 1;
        } else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = SD;
            rotation = -135;
            move = 1;
        } else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = SA;
            rotation = 135;
            move = 1;
        } else if(Input.GetKey(KeyCode.S))
        {
            transform.rotation = S;
            rotation = -180;
            move = 1;
        } else if(Input.GetKey(KeyCode.W))
        {
            transform.rotation = W;
            rotation = 0;
            move = 1;
        } else if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = A;
            rotation = 90;
            move = 1;
        } else if(Input.GetKey(KeyCode.D))
        {
            transform.rotation = D;
            rotation = -90;
            move = 1;
        } else
        {
            move = 0;
        }

    }
    private void LateUpdate() 
    {
        if(Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.A)) 
        {
            transform.rotation = W;
        } else if(Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.D)) 
        {
            transform.rotation = D;
        } else if(Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.D)) 
        {
            transform.rotation = S;
        } else if(Input.GetKeyUp(KeyCode.S) && Input.GetKeyUp(KeyCode.A)) 
        {
            transform.rotation = A;
        }
    }
    
}   
