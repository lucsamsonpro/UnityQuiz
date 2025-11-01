using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SimpleTimer : MonoBehaviour
{
    public bool TimerOn = false;
    public float targetTime;
    private Text TimerDisplay;
    private int IntTargetTime;

    private void Start()
    {
        TimerDisplay = GameObject.Find("Chrono").GetComponent<Text>();
    }

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
        IntTargetTime = (int)targetTime;
        TimerDisplay.text = "Chrono\n" + IntTargetTime + "s";
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