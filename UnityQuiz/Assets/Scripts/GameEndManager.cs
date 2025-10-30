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
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageBonneRéponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageMauvaiseRéponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageTempsEcoulé();
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
            GameObject.Find("QuizManager").GetComponent<ViewManager>().AfficherMessageGagné();
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
        {FinNbrQuestions.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count + " question posée";}
        else
        {FinNbrQuestions.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IndexMemory.Count + " questions posées";}

        if(GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore <=1)
        {FinRightScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore + " bonne réponse";}
        else
        {FinRightScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().RightScore + " bonnes réponses";}

        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore <= 1)
        {FinWrongScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore + " mauvaise réponse";}
        else
        {FinWrongScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().WrongScore + " mauvaises réponses";}


        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore <= 1)
        {FinAnsweredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore + " question répondue";}
        else
        {FinAnsweredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().AnsweredScore + " questions répondues";}


        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore <= 1)
        {FinIgnoredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore + " question ignorée";}
        else
        {FinIgnoredScore.text = GameObject.Find("QuizManager").GetComponent<QuestionManager>().IgnoredScore + " questions ignorées";}



    }



    public void Restart()
    {
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().CouleurQuestion();
        GameObject.Find("QuizManager").GetComponent<ButtonsManager>().ActiverBoutons();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageGagné();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessagePerdu();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageBonneRéponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageMauvaiseRéponse();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherMessageTempsEcoulé();
        GameObject.Find("QuizManager").GetComponent<QuestionManager>().StartQuiz();
    }
}

