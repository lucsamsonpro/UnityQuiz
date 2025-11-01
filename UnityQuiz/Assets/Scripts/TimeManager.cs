using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    public bool TimerOn = false;
    public float targetTime;
    private int IntTargetTime;
    private Text TexteChrono;

    private void Start()
    {
        //TexteChrono = GameObject.Find("TexteChrono").GetComponent<Text>();
    }

    void Update()
    {
        if (TimerOn == true)
        {
            GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherChrono();
            TexteChrono = GameObject.Find("TexteChrono").GetComponent<Text>();
            TexteChrono.text = " " + IntTargetTime + " ";
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                TimerEnded();
            }
        }
        else
        {
            GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherChrono();
        }
        IntTargetTime = (int)targetTime;
    }

    public void TimerStart()
    {
        Debug.Log("Lancement timer");
        targetTime = 10.0f;
        TimerOn = true;
    }

    void TimerEnded()
    {
        TimerOn = false;
        Debug.Log("Fin timer");
        StartCoroutine(TempsEcoulé());
    }

    IEnumerator TempsEcoulé()
    {
        Debug.Log("Temps écoulé");
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().DésactiverBoutons();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurRéponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageTempsEcoulé();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore += 1;
        yield return new WaitForSecondsRealtime(2);
        GameObject.Find("QuizManager").GetComponent<GameEndManager>().IsThisTheEnd();
    }
}