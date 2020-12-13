using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public DoorController doorController; 
    void Start()
    {
        doorController = GetComponent<DoorController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.keyPicked == true)
        {
            doorController.enabled = true;
        }
    }
}
