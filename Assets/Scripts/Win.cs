using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject Level;
    public static float score;
    private Timer Timmer;

    void Awake()
    {
        Timmer = Level.GetComponent<Timer>();
        score = 0;
    }

    [SerializeField] private string levevel;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            score = 1000 - Timmer.currentTime;
            Debug.Log(score.ToString());
            SceneManager.LoadScene(levevel);
        }
	}

}
