using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScoreText;

    private int _playerScore;

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        Debug.Log(_playerScore);
    }
    

}
