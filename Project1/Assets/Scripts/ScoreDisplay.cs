using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreDisplay : MonoBehaviour
{

    public int heightScore;
    public TextMeshProUGUI textBox;
    private GameObject player;

    private static ScoreDisplay _score;

    public static ScoreDisplay score
    {
        get
        {
            if( _score == null)
            {
                _score = FindObjectOfType<ScoreDisplay>();
            }
            return _score;
        }
    }

  

    private void Awake()
    {
       // textBox = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        if(_score != null)
        {
            Destroy(this);
        }
        else
        {
            _score = this;
            DontDestroyOnLoad(this);
        }
        if(SceneManager.GetActiveScene().name == "Main"){
        player = GameObject.FindGameObjectWithTag("Player");
        }


    }

    private void Update()
    {
        textBox = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();

        if (SceneManager.GetActiveScene().name == "Main"){
        if (heightScore <= player.transform.position.y)      //if player falls below highest score we so not update the display score
        {
            heightScore = (int)player.transform.position.y;
            
        }

    }
        textBox.text = heightScore.ToString();
       

    }


}
