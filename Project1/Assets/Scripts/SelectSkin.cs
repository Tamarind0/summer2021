using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//This is for the change outfit screen to keep track of the current skin and apply the skin that is clicked on
public class SelectSkin : MonoBehaviour
{
    //button functions similar to button manager where we make functions for buttons
    private PlayerSingleton player;

    [SerializeField]
    Sprite redSkin, blueSkin, greenSkin;

    private void Start()
    {
        if(GameObject.Find("PlayerSingleton") != null)
        {
            player = GameObject.Find("PlayerSingleton").GetComponent<PlayerSingleton>();
        }
    }
    public void SelectRedSkin()
    {
        player.currentSprite = redSkin;
    }

    public void SelectBlueSkin()
    {
        player.currentSprite = blueSkin;
    }

    public void SelectGreenSkin()
    {
        player.currentSprite = greenSkin;
    }
}
