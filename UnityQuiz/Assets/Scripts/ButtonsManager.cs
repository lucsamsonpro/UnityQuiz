using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    private Color Bleu = new Color(0.130162f, 0.2080058f, 0.3679245f);
    private Color Rouge = new Color(0.6039216f, 0.1254902f, 0.1647059f);
    private Color Vert = new Color(0.1254902f, 0.5686275f, 0.1568628f);



    public void CouleurQuestion()
    {
    GameObject.Find("Bouton1").GetComponent<Image>().color = Bleu;
    GameObject.Find("Bouton2").GetComponent<Image>().color = Bleu;
    GameObject.Find("Bouton3").GetComponent<Image>().color = Bleu;
    GameObject.Find("Bouton4").GetComponent<Image>().color = Bleu;
    }



    public void CouleurR�ponse()
    {
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().R�ponse == GameObject.Find("R�ponse1").GetComponent<Text>().text)
        {
            GameObject.Find("Bouton1").GetComponent<Image>().color = Vert;
        }
        else
        {
            GameObject.Find("Bouton1").GetComponent<Image>().color = Rouge;
        }
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().R�ponse == GameObject.Find("R�ponse2").GetComponent<Text>().text)
        {
            GameObject.Find("Bouton2").GetComponent<Image>().color = Vert;
        }
        else
        {
            GameObject.Find("Bouton2").GetComponent<Image>().color = Rouge;
        }
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().R�ponse == GameObject.Find("R�ponse3").GetComponent<Text>().text)
        {
            GameObject.Find("Bouton3").GetComponent<Image>().color = Vert;
        }
        else
        {
            GameObject.Find("Bouton3").GetComponent<Image>().color = Rouge;
        }
        if (GameObject.Find("QuizManager").GetComponent<QuestionManager>().R�ponse == GameObject.Find("R�ponse4").GetComponent<Text>().text)
        {
            GameObject.Find("Bouton4").GetComponent<Image>().color = Vert;
        }
        else
        {
            GameObject.Find("Bouton4").GetComponent<Image>().color = Rouge;
        }
    }



    public void ActiverBoutons()
    {
        GameObject.Find("Bouton1").GetComponent<Button>().enabled = true;
        GameObject.Find("Bouton2").GetComponent<Button>().enabled = true;
        GameObject.Find("Bouton3").GetComponent<Button>().enabled = true;
        GameObject.Find("Bouton4").GetComponent<Button>().enabled = true;
    }



    public void D�sactiverBoutons()
    {
        GameObject.Find("Bouton1").GetComponent<Button>().enabled = false;
        GameObject.Find("Bouton2").GetComponent<Button>().enabled = false;
        GameObject.Find("Bouton3").GetComponent<Button>().enabled = false;
        GameObject.Find("Bouton4").GetComponent<Button>().enabled = false;
    }

}
