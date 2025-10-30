using UnityEngine;
using System.Collections;

public class SimpleTimer : MonoBehaviour
{
    public bool TimerOn = false;
    public float targetTime;

    void Update()
    {
        if(TimerOn == true)
        {
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Le timer se lance");
        targetTime = 5.0f;
        TimerOn = true;
    }

    void timerEnded()
    {
        TimerOn = false;
        Debug.Log("Le temps est écoulé");
        Debug.Log(targetTime);
    }

}