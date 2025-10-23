using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 10;
    public int TimeLeft = 10;
    
    void OnEnable()
    {
        Debug.Log("Starting timer");
        var routine = TimerLoop(timer);
        StartCoroutine(routine);
    }

    public IEnumerator TimerLoop(float duration)
    {
        yield return new WaitForSeconds(duration);
        TimeLeft = 0;
        gameObject.SetActive(false);
        Debug.Log("No more time left");
        gameObject.SetActive(false);
    }
}
