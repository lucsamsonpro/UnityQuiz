using JetBrains.Annotations;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject EcranDeDébut;
    public GameObject EcranDeQuiz;
    public GameObject Chrono;
    public GameObject MessageBonneRéponse;
    public GameObject MessageMauvaiseRéponse;
    public GameObject MessageTempsEcoulé;
    public GameObject MessageNouvelleQuestion;
    public GameObject EcranDeFin;
    public GameObject ScoreFin_Questions;
    public GameObject ScoreFin_BonnesRéponses;
    public GameObject ScoreFin_MauvaisesRéponses;
    public GameObject MessageGagné;
    public GameObject MessagePerdu;
    
        void Start()
    {
        EcranDeDébut.SetActive(true);
        EcranDeQuiz.SetActive(true);
        Chrono.SetActive(false);
        MessageBonneRéponse.SetActive(false);
        MessageMauvaiseRéponse.SetActive(false);
        MessageTempsEcoulé.SetActive(false);
        MessageNouvelleQuestion.SetActive(false);
        EcranDeFin.SetActive(false);
        ScoreFin_Questions.SetActive(false);
        ScoreFin_BonnesRéponses.SetActive(false);
        ScoreFin_MauvaisesRéponses.SetActive(false);
        MessageGagné.SetActive(false);
        MessagePerdu.SetActive(false);
    }

    public void AfficherEcranDeDébut()
    {
        EcranDeDébut.SetActive(true);
    }

    public void CacherEcranDeDébut()
    {
        EcranDeDébut.SetActive(false);
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

    public void AfficherMessageTempsEcoulé()
    {
        MessageTempsEcoulé.SetActive(true);
    }

    public void CacherMessageTempsEcoulé()
    {
        MessageTempsEcoulé.SetActive(false);
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
        ScoreFin_BonnesRéponses.SetActive(true);
        ScoreFin_MauvaisesRéponses.SetActive(true);
    }

    public void CacherEcranDeFin()
    {
        EcranDeFin.SetActive(false);
        ScoreFin_Questions.SetActive(false);
        ScoreFin_BonnesRéponses.SetActive(false);
        ScoreFin_MauvaisesRéponses.SetActive(false);
    }

    public void AfficherMessageGagné()
    {
        MessageGagné.SetActive(true);
    }

    public void CacherMessageGagné()
    {
        MessageGagné.SetActive(false);
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
