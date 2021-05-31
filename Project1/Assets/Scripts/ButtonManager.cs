using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //button functionality
    public void MainMenuLoad()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ChangeOutfitLoad()
    {
        SceneManager.LoadScene("Change Outfit");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
        Cursor.lockState = CursorLockMode.Locked; // diables the cursor
    }

    public void ButtonAudio(){
        FindObjectOfType<AudioManager>().Play("ClickAudio");
    }

    public void LeaderBoardLoad(){
        SceneManager.LoadScene("LeaderBoard");
    }
}
