using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour
{
    public bool TimerOn = false;
    public float targetTime;

    void Update()
    {
        if (TimerOn == true)
        {
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                TimerEnded();
            }
        }
    }

    public void TimerStart()
    {
        Debug.Log("Lancement timer");
        targetTime = 5.0f;
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