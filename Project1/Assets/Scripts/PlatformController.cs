using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    //atached to platform prefabs
    [SerializeField]
    float jumpForce;

    private void OnCollisionEnter2D(Collision2D collision){
     if(collision.relativeVelocity.y <= 0f){ //used to determine that the player is landing on the platform
                                            // bc the when it's less than 0 that means the velocity is neg since
                                            // it is falling
        if(collision.rigidbody != null){    //!= null means when the rigidbody hits the platform, so when it doesn't hit the plaform nothing happens
            if(this.tag == "SuperJump")
                {//finds player animator component to play the flip
                    GameObject.Find("Player").GetComponent<Animator>().Play("playerFlip");
                    
                    FindObjectOfType<AudioManager>().Play("SuperJump");

                    
                }
                if (this.tag == "NormalPlatform")
                {
                    FindObjectOfType<AudioManager>().Play("Jump");
                }
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                collision.rigidbody.velocity = transform.up * jumpForce;
        }
     }
    }
}
