using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreDisplay : MonoBehaviour
{
    //used to display to the score on the Main scene
    [SerializeField] private TextMeshProUGUI textBox;
    [SerializeField] private GameObject player;
    private ScoreCounter _score;

    void Start(){
        if(GameObject.Find("ScoreCounter") != null){
            _score = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
            _score.heightScore = 0;
        }
    }

    void Update()
    {
        if (_score.heightScore <= player.transform.position.y)      //if player falls below highest score we so not update the display score
        {
            _score.heightScore = (int)player.transform.position.y;
        }
        textBox.text = _score.heightScore.ToString(); 
    }
}
