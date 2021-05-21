using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField]
    float jumpForce;


    private void OnCollisionEnter2D(Collision2D col){
     
        if(col.rigidbody != null){
            
            col.rigidbody.velocity = transform.up * jumpForce;
        }
    }

}
