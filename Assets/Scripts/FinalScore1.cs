using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore1 : MonoBehaviour
{
    private TMP_Text ScoreTracker;
    private void Update()
    {
        ScoreTracker = GetComponent<TMP_Text>();

        ScoreTracker.text = Win.score.ToString();
    }
}