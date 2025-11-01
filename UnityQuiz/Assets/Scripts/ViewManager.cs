using JetBrains.Annotations;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject EcranDeD�but;
    public GameObject EcranDeQuiz;
    public GameObject Chrono;
    public GameObject MessageBonneR�ponse;
    public GameObject MessageMauvaiseR�ponse;
    public GameObject MessageTempsEcoul�;
    public GameObject MessageNouvelleQuestion;
    public GameObject EcranDeFin;
    public GameObject ScoreFin_Questions;
    public GameObject ScoreFin_BonnesR�ponses;
    public GameObject ScoreFin_MauvaisesR�ponses;
    public GameObject MessageGagn�;
    public GameObject MessagePerdu;
    
        void Start()
    {
        EcranDeD�but.SetActive(true);
        EcranDeQuiz.SetActive(true);
        Chrono.SetActive(false);
        MessageBonneR�ponse.SetActive(false);
        MessageMauvaiseR�ponse.SetActive(false);
        MessageTempsEcoul�.SetActive(false);
        MessageNouvelleQuestion.SetActive(false);
        EcranDeFin.SetActive(false);
        ScoreFin_Questions.SetActive(false);
        ScoreFin_BonnesR�ponses.SetActive(false);
        ScoreFin_MauvaisesR�ponses.SetActive(false);
        MessageGagn�.SetActive(false);
        MessagePerdu.SetActive(false);
    }

    public void AfficherEcranDeD�but()
    {
        EcranDeD�but.SetActive(true);
    }

    public void CacherEcranDeD�but()
    {
        EcranDeD�but.SetActive(false);
    }

    public void AfficherEcranDeQuiz()
    {
        EcranDeQuiz.SetActive(true);
    }

    public void CacherEcranDeQuiz()
    {
        EcranDeQuiz.SetActive(false);
    }

    public void AfficherChrono()
    {
        Chrono.SetActive(true);
    }

    public void CacherChrono()
    {
        Chrono.SetActive(false);
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

    public void AfficherMessageTempsEcoul�()
    {
        MessageTempsEcoul�.SetActive(true);
    }

    public void CacherMessageTempsEcoul�()
    {
        MessageTempsEcoul�.SetActive(false);
    }

    public void AfficherMessageNouvelleQuestion()
    {
        MessageNouvelleQuestion.SetActive(true);

    }

    public void CacherMessageNouvelleQuestion()
    {
        MessageNouvelleQuestion.SetActive(false);

    }

    public void AfficherEcranDeFin()
    {
        EcranDeFin.SetActive(true);
        ScoreFin_Questions.SetActive(true);
        ScoreFin_BonnesR�ponses.SetActive(true);
        ScoreFin_MauvaisesR�ponses.SetActive(true);
    }

    public void CacherEcranDeFin()
    {
        EcranDeFin.SetActive(false);
        ScoreFin_Questions.SetActive(false);
        ScoreFin_BonnesR�ponses.SetActive(false);
        ScoreFin_MauvaisesR�ponses.SetActive(false);
    }

    public void AfficherMessageGagn�()
    {
        MessageGagn�.SetActive(true);
    }

    public void CacherMessageGagn�()
    {
        MessageGagn�.SetActive(false);
    }

    public void AfficherMessagePerdu()
    {
        MessagePerdu.SetActive(true);
    }

    public void CacherMessagePerdu()
    {
        MessagePerdu.SetActive(false);
    }
}
