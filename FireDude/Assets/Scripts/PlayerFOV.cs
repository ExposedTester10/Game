using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFOV : MonoBehaviour
{
    public float WaterLevel;
    [SerializeField] GameObject Player;
    [SerializeField] float WaterBottleDrain = 100f;
    [SerializeField] float BucketDrain = 50f;
    [SerializeField] float PistolDrain = 20f;
    [SerializeField] float BazookaDrain = 100f;
    public int Tool = 1;
    [SerializeField] GameObject SizeSmall;
    public int Score;
    public int money;

    // Turorial

    void Start() 
    {
      Score = 0;
      WaterLevel = 100f;  
      Debug.Log("Buttons are as follows");
      Debug.Log("F - Check tool");
      Debug.Log("WASD - Movement");
      Debug.Log("T - Check score");
      Debug.Log("R - Relod at nearest water fountain (Triangles)");
      Debug.Log("Space - Douse fire");
      Debug.Log("UpArrow - Switch tool up");
      Debug.Log("DownArrow - Switch tool down");
      Debug.Log("Reach as score of 1450 to win");
    }

    // Player input and response

    private void Update() 
    {

        transform.position = Player.transform.position;
        transform.rotation = Player.transform.rotation; 

       /* if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Tool += 1;
            Debug.Log("Tool Changed");
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Tool -=1;
            Debug.Log("Tool Changed");
        }

         if(Input.GetKey(KeyCode.T))
        {
            Debug.Log("Your Score is " + Score);
        } */
    }

    private void OnTriggerStay2D(Collider2D other) 
    {

         //Reloading at fountain

        if(other.tag == "Water Fountain" && Input.GetKey(KeyCode.R))
        {
            WaterLevel = 100f;
            Debug.Log("Reloaded");
        }
        
        /* Different Fire types and making them decrease in size with
        The press of space. Tool system put in place here*/

        if(Tool == 1) 
        {
                if(other.tag == "FireSmall" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.10f, 0.10f, 0);
                WaterLevel -= WaterBottleDrain;
            } else if(other.tag == "FireMedium" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.10f, 0.10f, 0);
                WaterLevel -= WaterBottleDrain;
            } else if(other.tag == "FireLarge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.10f, 0.10f, 0);
                WaterLevel -= WaterBottleDrain;
            } else if(other.tag == "FireHuge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.10f, 0.10f, 0);
                WaterLevel -= WaterBottleDrain;
            }
        } else if(Tool == 2)
        {
            if(other.tag == "FireSmall" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.20f, 0.20f, 0);
                WaterLevel -= BucketDrain;
            } else if(other.tag == "FireMedium" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.20f, 0.20f, 0);
                WaterLevel -= BucketDrain;
            } else if(other.tag == "FireLarge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.20f, 0.20f, 0);
                WaterLevel -= BucketDrain;
            } else if(other.tag == "FireHuge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.20f, 0.20f, 0);
                WaterLevel -= BucketDrain;
            }
        } else if(Tool == 3)
        {
            if(other.tag == "FireSmall" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.15f, 0.15f, 0);
                WaterLevel -= PistolDrain;
            } else if(other.tag == "FireMedium" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.15f, 0.15f, 0);
                WaterLevel -= PistolDrain;
            } else if(other.tag == "FireLarge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.15f, 0.15f, 0);
                WaterLevel -= PistolDrain;
            } else if(other.tag == "FireHuge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.15f, 0.15f, 0);
                WaterLevel -= PistolDrain;
            }
        } else if(Tool == 4)
        {
            if(other.tag == "FireSmall" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
                WaterLevel -= BazookaDrain;
            } else if(other.tag == "FireMedium" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
                WaterLevel -= BazookaDrain;
            } else if(other.tag == "FireLarge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
                WaterLevel -= BazookaDrain;
            } else if(other.tag == "FireHuge" && Input.GetKey(KeyCode.Space) && WaterLevel >= 1) 
            {
                other.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
                WaterLevel -= BazookaDrain;
            }
        } else if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Not a valid Tool");
        }

        /* Destroying fire object after it reaches a certain magnatude and adding 
        Score accordingly*/
        if(other.tag == "FireSmall" && other.transform.localScale.magnitude <= SizeSmall.transform.localScale.magnitude)
        {
            Destroy(other.gameObject);
            Score += 20;
            money += 2;
        } else if(other.tag == "FireMedium" && other.transform.localScale.magnitude <= SizeSmall.transform.localScale.magnitude)
        {
            Destroy(other.gameObject);
            Score += 50;
            money += 5;
        } else if(other.tag == "FireLarge" && other.transform.localScale.magnitude <= SizeSmall.transform.localScale.magnitude)
        {
            Destroy(other.gameObject);
            Score += 100;
            money += 7;
        } else if(other.tag == "FireHuge" && other.transform.localScale.magnitude <= SizeSmall.transform.localScale.magnitude)
        {
            Destroy(other.gameObject);
            Score += 200;
            money += 10;
        }

    }
}
