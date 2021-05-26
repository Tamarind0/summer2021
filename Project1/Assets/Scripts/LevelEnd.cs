using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelEnd : MonoBehaviour
{
    private string playerName;
    [SerializeField] private TextMeshProUGUI textBox;

    [SerializeField] private TMP_InputField inputField;
    private ScoreCounter _score;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if(GameObject.Find("ScoreCounter") != null){
            _score = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
            }
            fillTextBox();
            inputField.characterLimit = 4;
            
    }
   public void fillTextBox(){

       textBox.text = _score.heightScore.ToString();
    }

    public void PlayerNameInput(){
        playerName = inputField.text;
        _score.playerName = this.playerName;
        inputField.readOnly = true;
        
    }

}
