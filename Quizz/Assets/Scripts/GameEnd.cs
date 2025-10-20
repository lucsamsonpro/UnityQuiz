using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public int nbrRightAnswers = 0;
    public int nbrWrongAnswers = 0;
    public Timer TimerScript;
    // Update is called once per frame
    void Update()
    {
        if (nbrRightAnswers >= 5 || nbrWrongAnswers >= 5 || TimerScript.TimeLeft <= 0)
        {
            SceneManager.LoadScene("GameEnd");
            Debug.Log("Loading GameEnd scene");
        }
    }
}
