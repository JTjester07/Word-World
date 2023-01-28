using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorO : MonoBehaviour
{
    public GameObject EnterTheGates;

    public GameObject LetterP;
    private WordSensorP WordSensorP;

    public GameObject LetterE;
    private WordSensorE WordSensorE;

    void Awake()
	{
        WordSensorP = LetterP.GetComponent<WordSensorP>();
        WordSensorE = LetterE.GetComponent<WordSensorE>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterP" && WordSensorP.LetterPconnect && WordSensorE.LetterEconnect)
        {
            Destroy(EnterTheGates);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
