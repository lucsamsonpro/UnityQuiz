using JetBrains.Annotations;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject MessageBonneRéponse;
    public GameObject MessageMauvaiseRéponse;
    public GameObject MessageNouvelleQuestion;

        void Start()
    {
        MessageBonneRéponse.SetActive(false);
        MessageMauvaiseRéponse.SetActive(false);
        MessageNouvelleQuestion.SetActive(false);
    }

    public void AfficherMessageBonneRéponse()
    {
        MessageBonneRéponse.SetActive(true);
    }

    public void CacherMessageBonneRéponse()
    {
        MessageBonneRéponse.SetActive(false);
    }

    public void AfficherMessageMauvaiseRéponse()
    {
        MessageMauvaiseRéponse.SetActive(true);
    }

    public void CacherMessageMauvaiseRéponse()
    {
        MessageMauvaiseRéponse.SetActive(false);
    }

    public void AfficherMessageNouvelleQuestion()
    {
        MessageNouvelleQuestion.SetActive(true);

    }
    public void CacherMessageNouvelleQuestion()
    {
        MessageNouvelleQuestion.SetActive(false);

    }
}
