using UnityEngine;

public class Restart_SameScene : MonoBehaviour
{
    public Timer TimerScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TimerScript.gameObject.SetActive(false);
            Debug.Log("Timer stopped");
            TimerScript.gameObject.SetActive(true);
            Debug.Log("Restarting quizz");
        }
    }
}
