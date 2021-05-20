using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{

    [SerializeField]
    float RandomX, RandomY;

    [SerializeField]
    UnityEngine.GameObject Platform;

    UnityEngine.GameObject Player;

    private int ourX = 0, ourY = 0;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        StartingPlatform();
    }

    private void StartingPlatform()
    {
        
        


        
            //float randomX = UnityEngine.Random.Range(-RandomX, RandomX);
            //float randomY = UnityEngine.Random.Range(-RandomY, RandomY);
            Instantiate(Platform, new Vector3(ourX++, ourY++, 0), Quaternion.identity);
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.y % 2 == 0)
        {
            StartingPlatform();
        }

    }
}
