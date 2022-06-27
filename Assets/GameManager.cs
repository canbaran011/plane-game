using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _otherScore;

    public void PlayerScores(){
        _playerScore++;
        Debug.Log(_playerScore);
    }
    
    public void OtherScores(){
        _otherScore++;
        Debug.Log(_otherScore);
    }
}
