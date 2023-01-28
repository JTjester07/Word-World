using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
    float startTime;

    private void Start()
    {
        startTime = Time.timeSinceLevelLoad;
    }

    private void Update()
    {
        currentTime = Time.timeSinceLevelLoad - startTime;
    }
}
