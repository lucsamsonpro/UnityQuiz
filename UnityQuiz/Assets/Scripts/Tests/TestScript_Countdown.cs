using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int duration = 5;
    public int timeRemaining;
    public bool isCountingDown = false;
    private Text TimerDisplay;

    public void Begin()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("_tick", 1f);
        }
    }

    private void _tick()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("_tick", 1f);
        }
        else
        {
            isCountingDown = false;
        }
    }
}