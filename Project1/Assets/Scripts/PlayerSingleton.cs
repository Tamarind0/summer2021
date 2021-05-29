using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//player Singleton is to keep track of the active sprite on the player through scenes
public class PlayerSingleton : MonoBehaviour
{
    public static PlayerSingleton playerInstance;

    [SerializeField]
    public Sprite currentSprite;
    private void Awake()
    {
        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

    }

    
}