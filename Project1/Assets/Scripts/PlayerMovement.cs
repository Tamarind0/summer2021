using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private Rigidbody2D _player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
     float horizontalInput = Input.GetAxis("Horizontal");
     _player.velocity = new Vector2(horizontalInput * movementSpeed, _player.velocity.y);
    }
}
