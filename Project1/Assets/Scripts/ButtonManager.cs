using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
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
}
