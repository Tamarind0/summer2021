
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    [SerializeField]private GameObject Platform; // platform prefab

    [SerializeField]private Transform TopPoint; // the gameobject that is above the camera that will initailize the spawning of the platforms

    [SerializeField] private float distanceBetweenY; // separation between the platforms 
    [SerializeField] public float randomX, platformVariation; // separation between the platforms in the x direction
    [SerializeField] private float numofPlatforms;
    [SerializeField] GameObject specialPlatform;  //pink platforms that launch higher
    private float platformHeight; // box colliders height
   // private float platformWitdh;
    private GameObject newPlatform;

    private GameObject player;
//brackeys spawner no bueno
  void Start(){
    platformHeight = Platform.GetComponent<BoxCollider2D>().size.y; // we need a box collider to get how tall the platform is so they don't overlap.
  //  platformWitdh = Platform.GetComponent<BoxCollider2D>().size.x;
    player = GameObject.FindGameObjectWithTag("Player");
  }
    // Update is called once per frame
    void Update()
    {   
        if(player.transform.position.y > 300)
        {
            distanceBetweenY = 1.2f;
        }
    
        if(transform.position.y < TopPoint.position.y){
           for(int i = 0; i < numofPlatforms; i++){ // creating 10 platforms
            float xPosition = Random.Range(-randomX, randomX);
            //
            transform.position = new Vector3 (transform.position.x + xPosition, transform.position.y + platformHeight + distanceBetweenY, transform.position.z);
            newPlatform =  Instantiate(Platform, transform.position, transform.rotation);
            // multiple platforms on the same x
            //  float test  = -(transform.position.x + xPosition);
            // transform.position = new Vector3(test, transform.position.y, transform.position.z);
            //newPlatform = Instantiate(Platform, transform.position, transform.rotation);

             if((int)player.transform.position.y % 20 == 0 && (int) player.transform.position.y >= 2)
                {
                    transform.position = new Vector3(transform.position.x + xPosition, transform.position.y + platformHeight + distanceBetweenY, transform.position.z);
                    newPlatform = Instantiate(specialPlatform, transform.position, transform.rotation);
                }
                float randTemp = Random.Range(0, platformVariation);
                if (newPlatform.transform.position.x <= -7.0){// rearraging the platforms if they spawn too far from the center
             newPlatform.transform.position = new Vector3 (transform.position.x + 7.0f, transform.position.y, transform.position.z); //moving the newplatform to the new location
             transform.position = new Vector3 (transform.position.x + randTemp, transform.position.y, transform.position.z);// moving the spawner to the new location
           }
           else if(newPlatform.transform.position.x >= 7.0){ // rearraging the platforms if they spawn too far from the center
             newPlatform.transform.position = new Vector3 (transform.position.x - randTemp, transform.position.y, transform.position.z);//moving the newplatform to the new location
             transform.position = new Vector3 (transform.position.x - 7.0f, transform.position.y, transform.position.z);// moving the spawner to the new location
           }
           }
         } 
        }
        
    
}
