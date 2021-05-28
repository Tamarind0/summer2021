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

    private bool myBool = true;
 

    // Update is called once per frame
    void Update()
    {
        if(_player.transform.position.y > maxHeight){
            maxHeight = _player.transform.position.y;
            transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - lowerBoundValue, _player.transform.position.z);
        }
        if(_player.transform.position.y < transform.position.y){
            if (myBool)
            {
              
                 FindObjectOfType<AudioManager>().Play("Death");
                myBool = false;
            }

            Vanish();
            LevelEnd.Start();
            LevelEnd.Spawn();
            

        }
        
    }

    private void Vanish(){
        otherCanvas.text = " ";
    }
}
