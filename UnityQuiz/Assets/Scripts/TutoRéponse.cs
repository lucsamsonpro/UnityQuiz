using UnityEngine;
using UnityEngine.UI;

public class TutoRéponse : MonoBehaviour
{
    public void RéponseChoisie()
    {
        if (GameObject.Find("QuizManager").GetComponent<TutoQuiz>().Réponse == transform.GetChild(0).GetComponent<Text>().text)
        {
            Debug.Log("Gagné");
            GameObject.Find("QuizManager").GetComponent<TutoQuiz>().Score += 1;
        }
        else
        {
            Debug.Log("Perdu");
        }

        GameObject.Find("QuizManager").GetComponent<TutoQuiz>().PoseUneQuestion();
    }

   
}
