using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFOV : MonoBehaviour
{
    [SerializeField] GameObject SizeSmall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.tag == "Fire" && Input.GetKey(KeyCode.Space)) 
        {
            other.transform.localScale -= new Vector3(0.01f, 0.01f, 0);
        }
        if(other.tag == "Fire" && other.transform.localScale.magnitude <= SizeSmall.transform.localScale.magnitude)
        {
            Destroy(other.gameObject);
        }

    }
}
