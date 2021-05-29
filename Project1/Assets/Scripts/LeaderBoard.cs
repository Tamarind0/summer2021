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
            if(_score.LeaderBoardInfo.Count() < 10){
                int difference = 10 - _score.LeaderBoardInfo.Count();
                for(int i = 0; i < difference; i++){
                    _score.LeaderBoardInfo.Add("KEKW"+i, i);                    
                }

            }
    var item = _score.LeaderBoardInfo.OrderByDescending(pair => pair.Value).Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);
    foreach (KeyValuePair<string, int> kvp in item)
    {
        playerTXT.text += string.Format("{0}                         {1} \n", kvp.Key, kvp.Value);
    }
        

    }

}
