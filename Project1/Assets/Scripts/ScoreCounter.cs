using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    //singelton of the Players score
    public int heightScore;
    public string playerName;
    private static ScoreCounter _score;
    public static ScoreCounter score
    {
        get
        {
            if( _score == null)
            {
                _score = FindObjectOfType<ScoreCounter>();
            }
            return _score;
        }
    }

     void Awake()
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
    }

}
