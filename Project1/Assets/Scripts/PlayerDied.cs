using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDied : MonoBehaviour
{

    [SerializeField] private GameObject _player;
    [SerializeField] private float lowerBoundValue;
    private float maxHeight = 0f;

    // Update is called once per frame
    void Update()
    {
        if(_player.transform.position.y > maxHeight){
            maxHeight = _player.transform.position.y;
            transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y - lowerBoundValue, _player.transform.position.z);
        }
        if(_player.transform.position.y < transform.position.y){
           
            SceneManager.LoadScene("GameOver");
        }
        
    }
}
