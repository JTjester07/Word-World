using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorS : MonoBehaviour
{
    public bool LetterSconnect = false;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterT")
        {
            LetterSconnect = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterT")
        {
            LetterSconnect = false;
        }
    }
}
