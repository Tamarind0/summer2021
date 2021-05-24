using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDied : MonoBehaviour
{

    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        if(_player.transform.position.y < transform.position.y){ //player fell and is now by the despawner
            SceneManager.LoadScene("GameOver");
        }
    }
}
