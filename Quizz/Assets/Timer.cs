using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 10;
    //private float elapsedTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //elapsedTime = 0;
        var routine = TimerLoop(timer);
        StartCoroutine(routine);
    }

    //private void Update()
    //{
    //    if (elapsedTime > timer)
    //    {
    //        Debug.Log("Cick !!!");
    //    }
    //    else
    //    {
    //        elapsedTime += Time.deltaTime;
    //        Debug.Log(elapsedTime);
    //    }
    //}

    public IEnumerator TimerLoop(float duration)
    {
        yield return new WaitForSeconds(duration);
        Debug.Log("Timer End");
    }
}
