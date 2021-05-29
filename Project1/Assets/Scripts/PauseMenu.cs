using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Pause UI in the "Main" scene
public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    [SerializeField] private GameObject PauseCanvas;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(gamePaused){ // allowing the player to press ESC again to resume the game
                Resume();
            }else{
                Pause();
            } 
        }  
    }

    private void Pause(){
        PauseCanvas.gameObject.SetActive(true); // "spawning" the canvas
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;

        
    }
    public void Resume(){
        PauseCanvas.gameObject.SetActive(false);
         Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
}
