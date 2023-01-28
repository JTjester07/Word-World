using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSensorO1 : MonoBehaviour
{
    public GameObject EnterTheGates;

    public GameObject LetterP;
    private WordSensorP WordSensorP;

    public GameObject LetterE;
    private WordSensorE WordSensorE;

    public GameObject objectToSpawn;
    public GameObject Extend;

    public GameObject Pos1;
    private Transform Posss1;
    public GameObject Pos2;
    private Transform Posss2;
    public GameObject Pos3;
    private Transform Posss3;

    private bool once = true;

    void Awake()
	{
        WordSensorP = LetterP.GetComponent<WordSensorP>();
        WordSensorE = LetterE.GetComponent<WordSensorE>();
        Posss1 = Pos1.GetComponent<Transform>();
        Posss2 = Pos2.GetComponent<Transform>();
        Posss3 = Pos3.GetComponent<Transform>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LetterP" && WordSensorP.LetterPconnect && WordSensorE.LetterEconnect)
        {
            Destroy(EnterTheGates);
        }
        else if (collision.gameObject.name == "LetterN" && once)
		{
            Destroy(Extend);
            Instantiate(objectToSpawn, Posss1.position, Posss1.rotation);
            Instantiate(objectToSpawn, Posss2.position, Posss2.rotation);
            Instantiate(objectToSpawn, Posss3.position, Posss3.rotation);
            once = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
