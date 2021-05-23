
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{

    
    public float randomX = 1f;
  

    [SerializeField]private GameObject Platform;

   [SerializeField]private Transform TopPoint;

    [SerializeField] private float distanceBetweenY;
  
    private float platformHeight;

   // public float minY = .2f;
   // public float maxY = 1.5f;
   // public float levelWidth = 3f;

//brackeys spawner no bueno
  void Start(){
    platformHeight = Platform.GetComponent<BoxCollider2D>().size.y;
    
   // Vector3 spawn  = new Vector3();
   //     for(int i = 0; i < 4; i++){ 
   //             spawn.y += Random.Range(minY, maxY);
   //            spawn.x = Random.Range(-levelWidth, levelWidth);
   //      Instantiate(Platform, spawn, Quaternion.identity);
   //         }
 
  }
    // Update is called once per frame
    void Update()
    {   

        if(transform.position.y < TopPoint.position.y){
           for(int i = 0; i < 10; i++){ // creating 10 platforms
            float xPosition = Random.Range(-randomX, randomX);
            transform.position = new Vector3 (transform.position.x + xPosition, transform.position.y + platformHeight + distanceBetweenY, transform.position.z);
            GameObject newPlatform =  Instantiate(Platform, transform.position, transform.rotation);
           if(newPlatform.transform.position.x <= -6.0){// rearraging the platforms if they spawn too far from the center
             newPlatform.transform.position = new Vector3 (transform.position.x + 7.0f, transform.position.y, transform.position.z); //moving the newplatform to the new location
             transform.position = new Vector3 (transform.position.x + 7.0f, transform.position.y, transform.position.z);// moving the spawner to the new location
           }
           else if(newPlatform.transform.position.x >= 6.0){ // rearraging the platforms if they spawn too far from the center
             newPlatform.transform.position = new Vector3 (transform.position.x - 7.0f, transform.position.y, transform.position.z);//moving the newplatform to the new location
             transform.position = new Vector3 (transform.position.x - 7.0f, transform.position.y, transform.position.z);// moving the spawner to the new location
           }
           }
         } 
        }
        
    
}
