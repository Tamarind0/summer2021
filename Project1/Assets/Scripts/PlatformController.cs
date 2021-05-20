using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField]
    float jumpForce;

    [SerializeField]
    Rigidbody2D _player;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col){
        Debug.Log("HUH");
        if(col.gameObject.tag == "Player"){
            _player.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
