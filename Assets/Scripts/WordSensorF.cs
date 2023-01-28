using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorF : MonoBehaviour
{
    public GameObject Player;
    private PlayerMovement PlayerMovement;

    public GameObject LetterA;
    private WordSensorA WordSensorA;

    public GameObject LetterS;
    private WordSensorS WordSensorS;

    public int Speed_Change;

    public GameObject Increase;
    private Transform Transform;

    public GameObject Sign;
    private bool stop = true;

    void Awake()
	{
        WordSensorA = LetterA.GetComponent<WordSensorA>();
        WordSensorS = LetterS.GetComponent<WordSensorS>();
        PlayerMovement = Player.GetComponent<PlayerMovement>();
        Transform = Increase.GetComponent<Transform>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterA" && WordSensorA.LetterAconnect && WordSensorS.LetterSconnect)
        {
            PlayerMovement.speed = Speed_Change;
        }
        else if (collision.gameObject.name == "LetterA" && WordSensorA.LetterAconnectalt && stop)
		{
            Transform.localScale += new Vector3(0, -5, 0);
            Destroy(Sign);
            stop = false;
        }
    }
}
