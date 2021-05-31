using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerDied : MonoBehaviour
{


    [SerializeField] private GameObject _player;
    [SerializeField] private float lowerBoundValue;
    private float maxHeight = 0f;

    public LevelEnd LevelEnd; // calling on the LevelEnd script
    public TextMeshProUGUI otherCanvas;

    private bool deathSoundBool = true;
 

    // Update is called once per frame
    void Update()
    {
        if(_player.transform.position.y > maxHeight){ //checking if player is moving away from our lowerbound, if it is we update the lowerbound to the player but we still keep the distance so player is not reset immediately
            maxHeight = _player.transform.position.y; // lowerbound is close to the camera lower edge
            transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - lowerBoundValue, _player.transform.position.z);
        }
        if(_player.transform.position.y < transform.position.y){ //player fell too far and died
            if (deathSoundBool) //so the death sound does not replay over and over
            {
                 FindObjectOfType<AudioManager>().Play("Death");
                deathSoundBool = false;
            }

            Vanish();
            LevelEnd.Start(); //death sequence, look at level end script
            LevelEnd.Spawn();
            

        }
        
    }

    private void Vanish(){      //clears score canvas
        otherCanvas.text = " ";
    }
}
