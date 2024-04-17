using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    float movement;
    float acceleration;
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

    }
    
    void Update()
    {

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
        } else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = WA;
        } else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = SD;
        } else if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = SA;
        } else if(Input.GetKey(KeyCode.S))
        {
            transform.rotation = S;
        } else if(Input.GetKey(KeyCode.W))
        {
            transform.rotation = W;
        } else if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = A;
        } else if(Input.GetKey(KeyCode.D))
        {
            transform.rotation = D;
        }

    }
}
