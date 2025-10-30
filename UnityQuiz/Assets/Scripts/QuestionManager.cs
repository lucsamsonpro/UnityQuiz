using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class QuestionManager : MonoBehaviour

{
    private Text TexteQuestion;
    private int Index;
    public List<int> IndexMemory;
    private Text TexteRightScore;
    private Text TexteWrongScore;
    private Text NumeroQuestion;
    private Text TexteIgnoredScore;
    private Text TexteBouton1;
    private Text TexteBouton2;
    private Text TexteBouton3;
    private Text TexteBouton4;
    public string Réponse;
    public int RightScore;
    public int WrongScore;
    public int AnsweredScore;
    public int IgnoredScore;

    //Déclaration tableau
    public string[] Quiz;


    private void Start()
    {
        //Composants
        TexteQuestion = GameObject.Find("TexteQuestion").GetComponent<Text>();
        TexteRightScore = GameObject.Find("TexteRightScore").GetComponent<Text>();
        TexteWrongScore = GameObject.Find("TexteWrongScore").GetComponent<Text>();
        NumeroQuestion = GameObject.Find("NumeroQuestion").GetComponent<Text>();
        TexteIgnoredScore = GameObject.Find("TexteIgnoredScore").GetComponent<Text>();
        TexteBouton1 = GameObject.Find("Réponse1").GetComponent<Text>();
        TexteBouton2 = GameObject.Find("Réponse2").GetComponent<Text>();
        TexteBouton3 = GameObject.Find("Réponse3").GetComponent<Text>();
        TexteBouton4 = GameObject.Find("Réponse4").GetComponent<Text>();
    }
    public void StartQuiz()
    {
        //Affichage
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeDébut();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();

        //Initialisation
        Quiz = new string[10];
        RightScore = 0;
        WrongScore = 0;
        AnsweredScore = 0;
        IgnoredScore = 0;
        IndexMemory = new List<int>();

        //Déclaration du contenu du tableau
        Quiz[0] = "Qui a écrit Le Seigneur des Anneaux ?§Philip Pullman§Douglas Adams§J. R. R. Tolkien§C. S. Lewis§J. R. R. Tolkien";
        Quiz[1] = "Qui a écrit Les Misérables ?§Honoré de Balzac§Stendhal§George Sand§Victor Hugo§Victor Hugo";
        Quiz[2] = "Quand a été guillotiné Louis XVI ?§Le 14 juillet 1789§Le 21 janvier 1793§Le 21 septembre 1792§Le 16 octobre 1793§Le 21 janvier 1793";
        Quiz[3] = "Qui a écrit Hamlet ?§William Schakespear§William Shackespire§William Shrekhespeare§William Shakespeare§William Shakespeare";
        Quiz[4] = "Dans l’univers de Dune, quel est le nom de naissance d’Usul ?§Paul Atréides§Pierre Harkonnen§Jean Corrino§Benoît Gesserit§Paul Atréides";
        Quiz[5] = "À quelle dynastie appartiennent Agamemnon, Ménélas, Oreste et Électre ?§Arkonènes§Atrides§Corinthos§Théleilas§Atrides";
        Quiz[6] = "Quelle est la densité papale de la cité du Vatican ?§3,14 papes au km² §1 pape au km² §2,27 papes au km² §0,94 papes au km² §2,27 papes au km² ";
        Quiz[7] = "Quelles villes apparaissent dans Assassin’s Creed (2007) ?§Acre, Antioche et Édesse§Antioche, Damas et Jérusalem§Édesse, Jaffa et Jérusalem, §Acre, Damas et Jérusalem§Acre, Damas et Jérusalem";
        Quiz[8] = "Quel compositeur germano-américain a reçu l’Oscar de la meilleure musique de film en 1995 pour Le Roi Lion ?§Hans Zimmer§Otto Küche§Markus Garten§Friedrich Dusche§Hans Zimmer";
        Quiz[9] = "Quelle était la couleur du cheval blanc d’Henri IV ?§Bleu§Blanc§Rouge§C’était une licorne, pas un cheval§Blanc";


        QuizPoseUneQuestion();
    }

    void Update()
    {
        NumeroQuestion.text = "Question n° " + IndexMemory.Count;

        if(RightScore <= 1)
        {
            TexteRightScore.text = RightScore + " bonne réponse";
        }
        else
        {
            TexteRightScore.text = RightScore + " bonnes réponses";
        }

        if (WrongScore <=1 )
        {
            TexteWrongScore.text = WrongScore + " mauvaise réponse";
        }
        else
        {
            TexteWrongScore.text = WrongScore + " mauvaises réponses";
        }

        if (IgnoredScore <=1 )
        {
            TexteIgnoredScore.text = IgnoredScore + " question ignorée";
        }
        else
        {
            TexteIgnoredScore.text = IgnoredScore + " questions ignorées";
        }

    }
    public void QuizPoseUneQuestion()
    {
        QuizChoisitUneQuestion();
        string[] Col = Quiz[Index].Split('§');
        TexteQuestion.text = Col[0];
        TexteBouton1.text = Col[1];
        TexteBouton2.text = Col[2];
        TexteBouton3.text = Col[3];
        TexteBouton4.text = Col[4];
        Réponse = Col[5];
        GameObject.Find("QuizManager").GetComponent<TimeManager>().TimerStart();
    }

    public void QuizChoisitUneQuestion()
    {
        if (IndexMemory.Count == Quiz.Length)
        {
            Debug.Log("Toutes les questions ont été posées !");
        }
        else
        {
            Index = Random.Range(0, Quiz.Length);
            while (IndexMemory.Contains(Index))
            {
                Index = Random.Range(0, Quiz.Length);
            }
            IndexMemory.Add(Index);
        }
    }

}
