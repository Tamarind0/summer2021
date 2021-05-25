using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this script is attached to the Platform Prefab
public class PlatformDespawner : MonoBehaviour
{
    public GameObject BottomPointer;  // Gameobject that is attached below the Camera


    void Start(){
        BottomPointer = GameObject.Find("BottomPointer"); // need to find the gameobject since this script is attached to the prefab 
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position refers to a platforms y position
        if(transform.position.y < BottomPointer.transform.position.y){  // when the bottom pointer passes the y position of a platform it gets destroyed
            Destroy(this.gameObject);
        }
    }
}
