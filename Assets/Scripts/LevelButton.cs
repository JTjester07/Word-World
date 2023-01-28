using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{

    [SerializeField] private string level;

    public void PlayGame()
	{
        SceneManager.LoadScene(level);
	}

}
