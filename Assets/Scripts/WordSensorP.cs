using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorP : MonoBehaviour
{
    public bool LetterPconnect = false;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterE")
        {
            LetterPconnect = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterE")
        {
            LetterPconnect = false;
        }
    }
}
