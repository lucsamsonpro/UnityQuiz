using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class QuizRéponse : MonoBehaviour
{
    public void QuizRéponseChoisie()
    {
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().DésactiverBoutons();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurRéponse();
        if (GameObject.Find("QuizManager").GetComponent<QuizQuestion>().Réponse == transform.GetChild(0).GetComponent<Text>().text)
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
        GameObject.Find("QuizManager").GetComponent<QuizQuestion>().RightScore += 1;
        yield return new WaitForSecondsRealtime(3);
        StartCoroutine(NouvelleQuestion());
    }



    IEnumerator MauvaiseRéponse()
    {
        Debug.Log("Mauvaise réponse");
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageMauvaiseRéponse();
        GameObject.Find("QuizManager").GetComponent<QuizQuestion>().WrongScore += 1;
        yield return new WaitForSecondsRealtime(2);
        StartCoroutine(NouvelleQuestion());
    }



    IEnumerator NouvelleQuestion()
    {
        if (GameObject.Find("QuizManager").GetComponent<QuizQuestion>().IndexMemory.Count == GameObject.Find("QuizManager").GetComponent<QuizQuestion>().Quiz.Length)
        {
            Debug.Log("Toutes les questions ont été posées !");
        }
        else
        {
            GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageBonneRéponse();
            GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageMauvaiseRéponse();
            GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageNouvelleQuestion();
            yield return new WaitForSecondsRealtime(2);
            GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageNouvelleQuestion();
            GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurQuestion();
            GameObject.Find("QuizManager").GetComponent<QuizQuestion>().QuizPoseUneQuestion();
            GameObject.Find("QuizManager").GetComponent<ButtonsManager>().ActiverBoutons();
        }
    }
}
