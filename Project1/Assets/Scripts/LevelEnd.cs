using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelEnd : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textBox;
    private ScoreCounter _score;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if(GameObject.Find("ScoreCounter") != null){
            _score = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
            }
            fillTextBox();
    }
   public void fillTextBox(){

       textBox.text = ": " + _score.heightScore.ToString();
    }

}
