using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    //singelton of the Players score
    public int heightScore;
    public string playerName;

     public Dictionary<string, int> LeaderBoardInfo = new Dictionary<string, int>();
     //should store both the player name and height to be used in the leader board scene
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
            Debug.Log("Destroyed");
        }
        else
        {
            _score = this;
            DontDestroyOnLoad(this);
            Debug.Log("Not destroyed");
        }
    }

}
