using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
public class LeaderBoard : MonoBehaviour
{

    // this script is attached to the Canvas on LeaderBoard scene
    [SerializeField]private TextMeshProUGUI playerTXT;
    //[SerializeField]private TextMeshProUGUI playerScoreTXT;
    private ScoreCounter _score;
    
    
    // Start is called before the first frame update
    void Start()
    {       
        if(GameObject.Find("ScoreCounter") != null){
            _score = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
         }  

        foreach (var item in _score.LeaderBoardInfo.OrderByDescending(r => r.Value).Take(5))
        {
            playerTXT.text = item.Key + " " + item.Value.ToString() + "\n";
        }

    }

}
