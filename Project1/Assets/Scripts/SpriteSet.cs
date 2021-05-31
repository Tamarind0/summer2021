using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script sets whatever sprite playerSingleton is carrying to the player on start
public class SpriteSet : MonoBehaviour
{
    //Script attached to player that sets the sprite from the data stored in the player singleton
    private PlayerSingleton player;
    private void Start()
    {
        if (GameObject.Find("PlayerSingleton") != null)         //finds singeleton if it exists
        {
            player = GameObject.Find("PlayerSingleton").GetComponent<PlayerSingleton>();
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = player.currentSprite; //sets player sprite with the singleton sprite
    }
}
