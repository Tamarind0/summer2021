using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Pause UI in the "Main" scene
public class PauseMenu : MonoBehaviour
{
    private Vector2 playerVelocity;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject PauseCanvas;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            playerVelocity = rb.velocity;
            Pause();
        }
        
    }

    private void Pause(){
        PauseCanvas.gameObject.SetActive(true); // "spawning" the canvas
        Cursor.lockState = CursorLockMode.None;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        
    }

    public void Resume(){
        PauseCanvas.gameObject.SetActive(false);
         Cursor.lockState = CursorLockMode.Locked;
         rb.constraints = RigidbodyConstraints2D.None;
         rb.constraints = RigidbodyConstraints2D.FreezeRotation;
         rb.velocity = playerVelocity;
    }
}
