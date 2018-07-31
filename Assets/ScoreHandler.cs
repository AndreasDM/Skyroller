using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestText;
    private long currentHighScore = 0;
    private long bestScore = 0;

    private void Update()
    {
        
        currentHighScore = (long)gameObject.transform.position.z;
        if (currentHighScore > 0)
            scoreText.SetText(currentHighScore.ToString());

        if (currentHighScore > bestScore)
        {
            bestScore = currentHighScore;
            bestText.SetText(bestScore.ToString());
        }
    }
}
