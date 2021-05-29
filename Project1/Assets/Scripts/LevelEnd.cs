using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelEnd : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;

    [SerializeField] private TMP_InputField inputField;

    private ScoreCounter _score;

    [SerializeField] private Rigidbody2D rb;

    private TextMeshProUGUI otherCanvas;

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
       textBox.text = _score.heightScore.ToString();
       inputField.characterLimit = 4;
  
   }

    public void PlayerNameInput(){
        _score.playerName = inputField.text;
        inputField.readOnly = true;
        
    }

    public void SavePlayerInfo(){
        _score.LeaderBoardInfo.Add(_score.playerName, _score.heightScore);
    }
}
