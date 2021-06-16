using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDoor_Script : MonoBehaviour
{
    public bool isActivated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateDoor()
    {
        Debug.Log("Red Door Activated");
        isActivated = true;
    }
}
