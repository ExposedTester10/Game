using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlay : MonoBehaviour
{
    [SerializeField] GameObject Player;
    
    void LateUpdate() 
    {
        transform.position = Player.transform.position;
    }
}
