using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public int heightScore;
    public TextMeshProUGUI textBox;
    public GameObject player;

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
        if(_score != null)
        {
            Destroy(this);
        }
        else
        {
            _score = this;
            DontDestroyOnLoad(this);
        }

        player = GameObject.FindGameObjectWithTag("Player");


    }

    private void Update()
    {

        if (heightScore <= player.transform.position.y)      //if player falls below highest score we so not update the display score
        {
            heightScore = (int)player.transform.position.y;
            textBox.text = heightScore.ToString();
        }
    }


}
