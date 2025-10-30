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
    public string R�ponse;
    public int RightScore;
    public int WrongScore;
    public int AnsweredScore;
    public int IgnoredScore;

    //D�claration tableau
    public string[] Quiz;


    private void Start()
    {
        //Composants
        TexteQuestion = GameObject.Find("TexteQuestion").GetComponent<Text>();
        TexteRightScore = GameObject.Find("TexteRightScore").GetComponent<Text>();
        TexteWrongScore = GameObject.Find("TexteWrongScore").GetComponent<Text>();
        NumeroQuestion = GameObject.Find("NumeroQuestion").GetComponent<Text>();
        TexteIgnoredScore = GameObject.Find("TexteIgnoredScore").GetComponent<Text>();
        TexteBouton1 = GameObject.Find("R�ponse1").GetComponent<Text>();
        TexteBouton2 = GameObject.Find("R�ponse2").GetComponent<Text>();
        TexteBouton3 = GameObject.Find("R�ponse3").GetComponent<Text>();
        TexteBouton4 = GameObject.Find("R�ponse4").GetComponent<Text>();
    }
    public void StartQuiz()
    {
        //Affichage
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeD�but();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();

        //Initialisation
        Quiz = new string[10];
        RightScore = 0;
        WrongScore = 0;
        AnsweredScore = 0;
        IgnoredScore = 0;
        IndexMemory = new List<int>();

        //D�claration du contenu du tableau
        Quiz[0] = "Qui a �crit Le Seigneur des Anneaux�?�Philip Pullman�Douglas Adams�J. R. R. Tolkien�C. S. Lewis�J. R. R. Tolkien";
        Quiz[1] = "Qui a �crit Les Mis�rables�?�Honor� de Balzac�Stendhal�George Sand�Victor Hugo�Victor Hugo";
        Quiz[2] = "Quand a �t� guillotin� Louis XVI�?�Le 14 juillet 1789�Le 21 janvier 1793�Le 21 septembre 1792�Le 16 octobre 1793�Le 21 janvier 1793";
        Quiz[3] = "Qui a �crit Hamlet�?�William Schakespear�William Shackespire�William Shrekhespeare�William Shakespeare�William Shakespeare";
        Quiz[4] = "Dans l�univers de Dune, quel est le nom de naissance d�Usul�?�Paul Atr�ides�Pierre Harkonnen�Jean Corrino�Beno�t Gesserit�Paul Atr�ides";
        Quiz[5] = "� quelle dynastie appartiennent Agamemnon, M�n�las, Oreste et �lectre�?�Arkon�nes�Atrides�Corinthos�Th�leilas�Atrides";
        Quiz[6] = "Quelle est la densit� papale de la cit�du Vatican�?�3,14�papes�au km� �1�pape�au km� �2,27�papes�au km� �0,94�papes�au km� �2,27�papes�au km� ";
        Quiz[7] = "Quelles villes apparaissent dans Assassin�s Creed (2007)�?�Acre, Antioche et �desse�Antioche, Damas et J�rusalem��desse, Jaffa et J�rusalem, �Acre, Damas et J�rusalem�Acre, Damas et J�rusalem";
        Quiz[8] = "Quel compositeur germano-am�ricain a re�u l�Oscar de la meilleure musique de film en 1995 pour Le Roi Lion�?�Hans Zimmer�Otto K�che�Markus Garten�Friedrich Dusche�Hans Zimmer";
        Quiz[9] = "Quelle �tait la couleur du cheval blanc d�Henri IV�?�Bleu�Blanc�Rouge�C��tait une licorne, pas un cheval�Blanc";


        QuizPoseUneQuestion();
    }

    void Update()
    {
        NumeroQuestion.text = "Question n� " + IndexMemory.Count;

        if(RightScore <= 1)
        {
            TexteRightScore.text = RightScore + " bonne r�ponse";
        }
        else
        {
            TexteRightScore.text = RightScore + " bonnes r�ponses";
        }

        if (WrongScore <=1 )
        {
            TexteWrongScore.text = WrongScore + " mauvaise r�ponse";
        }
        else
        {
            TexteWrongScore.text = WrongScore + " mauvaises r�ponses";
        }

        if (IgnoredScore <=1 )
        {
            TexteIgnoredScore.text = IgnoredScore + " question ignor�e";
        }
        else
        {
            TexteIgnoredScore.text = IgnoredScore + " questions ignor�es";
        }

    }
    public void QuizPoseUneQuestion()
    {
        QuizChoisitUneQuestion();
        string[] Col = Quiz[Index].Split('�');
        TexteQuestion.text = Col[0];
        TexteBouton1.text = Col[1];
        TexteBouton2.text = Col[2];
        TexteBouton3.text = Col[3];
        TexteBouton4.text = Col[4];
        R�ponse = Col[5];
        GameObject.Find("QuizManager").GetComponent<TimeManager>().TimerStart();
    }

    public void QuizChoisitUneQuestion()
    {
        if (IndexMemory.Count == Quiz.Length)
        {
            Debug.Log("Toutes les questions ont �t� pos�es !");
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
