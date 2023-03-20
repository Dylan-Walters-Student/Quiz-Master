using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scorKeeper;
    void Awake()
    {
        scorKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void showFinalScore(){
        finalScoreText.text = "Congratulations!\nYou got a score of " +
                                scorKeeper.CalculateScore() + "%";
    }
}
