using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script sets whatever sprite playerSingleton is carrying to the player on start
public class SpriteSet : MonoBehaviour
{
    private PlayerSingleton player;
    private void Start()
    {
        if (GameObject.Find("PlayerSingleton") != null)
        {
            player = GameObject.Find("PlayerSingleton").GetComponent<PlayerSingleton>();
        }

        gameObject.GetComponent<SpriteRenderer>().sprite = player.currentSprite;
    }
}
