using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameEndManager : MonoBehaviour
{
    private Text FinNbrQuestions;
    private Text FinRightScore;
    private Text FinWrongScore;
    private Text FinAnsweredScore;
    private Text FinIgnoredScore;
    public void IsThisTheEnd()
    {

        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count == GameObject.Find("QuizManager").GetComponent<QuestionManager>().Quiz.Length || GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore >= 5 || GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore >= 5 || GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore >= 5)
        {
            Debug.Log("Fin du quiz !");
            ThisIsTheEnd();
        }
        else
        {
            StartCoroutine(NouvelleQuestion());
        }
    }



    IEnumerator NouvelleQuestion()
    {
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageBonneR�ponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageMauvaiseR�ponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageTempsEcoul�();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageNouvelleQuestion();
        yield return new WaitForSecondsRealtime(2);
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageNouvelleQuestion();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurQuestion();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().QuizPoseUneQuestion();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().ActiverBoutons();
    }



    public void ThisIsTheEnd()
    {
        GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherEcranDeFin();
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore >= 5)
        {
            GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageGagn�();
        }
        else
        {
            GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessagePerdu();
        }
        FinNbrQuestions = GameObject.Find("NbrQuestions").GetComponent<Text>();
        FinRightScore = GameObject.Find("NbrRight").GetComponent<Text>();
        FinWrongScore = GameObject.Find("NbrWrong").GetComponent<Text>();
        FinAnsweredScore = GameObject.Find("NbrAnswered").GetComponent<Text>();
        FinIgnoredScore = GameObject.Find("NbrIgnored").GetComponent<Text>();

        if(GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count <= 1)
        {FinNbrQuestions.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count + " question pos�e";}
        else
        {FinNbrQuestions.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count + " questions pos�es";}

        if(GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore <=1)
        {FinRightScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore + " bonne r�ponse";}
        else
        {FinRightScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore + " bonnes r�ponses";}

        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore <= 1)
        {FinWrongScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore + " mauvaise r�ponse";}
        else
        {FinWrongScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore + " mauvaises r�ponses";}


        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore <= 1)
        {FinAnsweredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore + " question r�pondue";}
        else
        {FinAnsweredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore + " questions r�pondues";}


        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore <= 1)
        {FinIgnoredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore + " question ignor�e";}
        else
        {FinIgnoredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore + " questions ignor�es";}



    }



    public void Restart()
    {
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurQuestion();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().ActiverBoutons();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageGagn�();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessagePerdu();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageBonneR�ponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageMauvaiseR�ponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageTempsEcoul�();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().StartQuiz();
    }
}

