
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{

    
    public float RandomX = 3f;

    [SerializeField]
   private GameObject Platform;

   [SerializeField]
   private Transform TopPoint;
    [SerializeField]
    private float distanceBetweenY;

    public float minY = .2f;
    public float maxY = 1.5f;
  //  public LayerMask mask;
    // Update is called once per frame
    void Update()
    {   
        if(transform.position.y < TopPoint.position.y){
            for(int i = 0; i < 4; i++){ // creating 4 platforms
                float randomY = Random.Range(minY, maxY);
                float randomX = Random.Range(-RandomX, RandomX);
              //  if(i < 3){
             transform.position = new Vector3 (randomX, transform.position.y, transform.position.z);
            GameObject newPlatform =  Instantiate(Platform, transform.position, transform.rotation);
          //  Debug.Log(mask.ToString());
           //  if(Pain.GetComponent<EdgeCollider2D>().IsTouchingLayers(mask) == true)
           //  {
            //     Debug.Log("DESTROYED");
           //      Destroy(Pain);
           //  } 
            //    }


/// I forgot why we did this
           //  transform.position = new Vector3 (randomX, transform.position.y + distanceBetweenY, transform.position.z);
           // GameObject Pain2 = Instantiate(Platform, transform.position, transform.rotation);
           //  if(Pain2.GetComponent<EdgeCollider2D>().IsTouchingLayers(mask) == true)
           //  {
           //      Debug.Log("L");
           //      Destroy(Pain2);
           //  } 
            }

           // transform.position = new Vector3 (randomX , transform.position.y + distanceBetween, transform.position.z);
         //  Instantiate(Platform, transform.position, transform.rotation);
         //   float randomX2 = randomX;
         //  randomX2 = Random.Range(-RandomX, RandomX);
         //   transform.position = new Vector3 (randomX2, transform.position.y + distanceBetween, transform.position.z);
         //   Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
