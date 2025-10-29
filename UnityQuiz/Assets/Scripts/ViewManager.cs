using JetBrains.Annotations;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject MessageBonneR�ponse;
    public GameObject MessageMauvaiseR�ponse;
    public GameObject MessageNouvelleQuestion;

        void Start()
    {
        MessageBonneR�ponse.SetActive(false);
        MessageMauvaiseR�ponse.SetActive(false);
        MessageNouvelleQuestion.SetActive(false);
    }

    public void AfficherMessageBonneR�ponse()
    {
        MessageBonneR�ponse.SetActive(true);
    }

    public void CacherMessageBonneR�ponse()
    {
        MessageBonneR�ponse.SetActive(false);
    }

    public void AfficherMessageMauvaiseR�ponse()
    {
        MessageMauvaiseR�ponse.SetActive(true);
    }

    public void CacherMessageMauvaiseR�ponse()
    {
        MessageMauvaiseR�ponse.SetActive(false);
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
