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

    //public void ChangeOutfitLoad()
   // {

    //}

    public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }
}
