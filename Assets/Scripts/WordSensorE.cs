using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorE : MonoBehaviour
{
    public bool LetterEconnect = false;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterN")
        {
            LetterEconnect = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterN")
        {
            LetterEconnect = false;
        }
    }
}
