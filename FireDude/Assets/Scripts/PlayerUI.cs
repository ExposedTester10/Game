using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] GameObject Water90;
    [SerializeField] GameObject Water80;
    [SerializeField] GameObject Water70;
    [SerializeField] GameObject Water60;
    [SerializeField] GameObject Water50;
    [SerializeField] GameObject Water40;
    [SerializeField] GameObject Water30;
    [SerializeField] GameObject Water20;
    [SerializeField] GameObject Water10;
    [SerializeField] GameObject Water0;
    PlayerFOV playerFov;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Camera;

    // Start is called before the first frame update
    void Awake()
    {
        playerFov = Player.GetComponent<PlayerFOV>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.transform.position + new Vector3(0, 0, 5);

       if(playerFov.WaterLevel >= 90)
        {
            Water90.SetActive(true);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 80 && playerFov.WaterLevel <90)
        {
            Water90.SetActive(false);
            Water80.SetActive(true);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 70 && playerFov.WaterLevel <80 )
        {
            Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(true);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 60 && playerFov.WaterLevel <70)
        {
            Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(true);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 50 && playerFov.WaterLevel <60)
        {
            Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(true);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 40 && playerFov.WaterLevel <50)
        {
            Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(true);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 30 && playerFov.WaterLevel <40)
        {
             Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(true);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 20 && playerFov.WaterLevel <30)
        {
            Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(true);
            Water10.SetActive(false);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 10 && playerFov.WaterLevel <20)
        {
             Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(true);
            Water0.SetActive(false);
        } else  if(playerFov.WaterLevel >= 0 && playerFov.WaterLevel <10)
        {
             Water90.SetActive(false);
            Water80.SetActive(false);
            Water70.SetActive(false);
            Water60.SetActive(false);
            Water50.SetActive(false);
            Water40.SetActive(false);
            Water30.SetActive(false);
            Water20.SetActive(false);
            Water10.SetActive(false);
            Water0.SetActive(true); 
        }
    }
}
