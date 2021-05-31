using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelEnd : MonoBehaviour
{
    //Attached to game over canvas
    [SerializeField] private TextMeshProUGUI scoreTextBox;
    [SerializeField]private TextMeshProUGUI highScoreBox;
    [SerializeField] private Rigidbody2D rb;
    private ScoreCounter _score;

    public void Start(){
        if(GameObject.Find("ScoreCounter") != null){
            _score = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
        }
    }

    // Start is called before the first frame update
   public void Spawn(){
       gameObject.SetActive(true); // appearing the canvas
       Cursor.lockState = CursorLockMode.None;
       rb.constraints = RigidbodyConstraints2D.FreezeAll;
       if(_score.heightScore > PlayerPrefs.GetInt("HighScore")){ //updating new high score
       PlayerPrefs.SetInt("HighScore", _score.heightScore);
        }
       highScoreBox.text = "HighScore "+ PlayerPrefs.GetInt("HighScore");
       scoreTextBox.text = _score.heightScore.ToString();

  
   }
}
