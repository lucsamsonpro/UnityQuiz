using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class AnswerManager : MonoBehaviour
{
    public void QuizRéponseChoisie()
    {
        GameObject.Find("QuizManager").GetComponent<TimeManager>().TimerOn = false;
        Debug.Log("Timer arrêté");
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().DésactiverBoutons();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurRéponse();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore += 1;
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().Réponse == transform.GetChild(0).GetComponent<Text>().text)
        {
            StartCoroutine(BonneRéponse());
        }
        else
        {
            StartCoroutine(MauvaiseRéponse());
        }
    }



    IEnumerator BonneRéponse()
    {
        Debug.Log("Bonne réponse");
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageBonneRéponse();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore += 1;
        yield return new WaitForSecondsRealtime(3);
        GameObject.Find("QuizManager").GetComponent<GameEndManager>().IsThisTheEnd();
            }



    IEnumerator MauvaiseRéponse()
    {
        Debug.Log("Mauvaise réponse");
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageMauvaiseRéponse();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore += 1;
        yield return new WaitForSecondsRealtime(2);
        GameObject.Find("QuizManager").GetComponent<GameEndManager>().IsThisTheEnd();
    }



}
