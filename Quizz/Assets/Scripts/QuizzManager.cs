using UnityEngine;

public class QuizzManager : MonoBehaviour
{
    public Timer TimerScript;
    public int PlayerAnswer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        Debug.Log("New question");
        PlayerAnswer = 0;
        TimerScript.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
