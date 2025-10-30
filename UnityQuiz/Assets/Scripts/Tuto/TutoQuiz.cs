using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutoQuiz : MonoBehaviour

{
    private Text TexteQuestion;
    private int Index;
    private Text TexteScore;
    private Text TexteBouton1;
    private Text TexteBouton2;
    public string R�ponse;
    public int Score = 0;

    //D�claration tableau
    string[] Quiz = new string[3];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Composants
        TexteQuestion = GameObject.Find("TexteQuestion").GetComponent<Text>();
        TexteScore = GameObject.Find("TexteScore").GetComponent<Text>();
        TexteBouton1 = GameObject.Find("R�ponse1").GetComponent<Text>();
        TexteBouton2 = GameObject.Find("R�ponse2").GetComponent<Text>();

        //D�claration du contenu du tableau
        Quiz[0] = "Dans l�univers de Dune, quel est le nom de naissance d�Usul�?�Paul Atr�ides�Pierre Harkonnen�Paul Atr�ides";
        Quiz[1] = "Dans la mythologie grecque, � quelle dynastie appartiennent Agamemnon, M�n�las, Oreste et �lectre�?�Atrides�Arkon�nes�Atrides";
        Quiz[2] = "Quelle est la densit� papale de la cit�du Vatican�?�1�pape�au km��2,27�papes�au km��2,27�papes�au km�";

        TutoPoseUneQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        TexteScore.text = "Score\n" + Score;
    }
    public void TutoPoseUneQuestion()
    { 
        Index=Random.Range(0, Quiz.Length);
        string[] Col = Quiz[Index].Split('�');
        TexteQuestion.text = Col[0];
        TexteBouton1.text = Col[1];
        TexteBouton2.text = Col[2];
        R�ponse = Col[3];
    }
}
