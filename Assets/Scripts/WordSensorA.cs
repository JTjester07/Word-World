using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorA : MonoBehaviour
{
    public bool LetterAconnect = false;
    public bool LetterAconnectalt = false;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterS")
        {
            LetterAconnect = true;
        }
        else if (collision.gameObject.name == "LetterT")
        {
            LetterAconnectalt = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterS")
        {
            LetterAconnect = false;
        }
        else if (collision.gameObject.name == "LetterT")
        {
            LetterAconnectalt = false;
        }
    }
}
