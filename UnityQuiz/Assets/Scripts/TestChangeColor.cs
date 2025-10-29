using UnityEngine;
using UnityEngine.UI;

public class TestChangeColor : MonoBehaviour
{
    private Color CouleurRouge = Color.red;
    private Color CouleurBleu = new Color (0.33f, 0.53f, 0.94f);
    private int Choix = 0;

    public void PeindrePanel()
    {
        if (Choix == 1)
        {
            PeindreEnBleu();
            Choix--;
        }
        else
        {
            PeindreEnRouge();
            Choix++;
        }
    }

    public void PeindreEnBleu()
    {
        GameObject.Find("Panel").GetComponent<Image>().color = CouleurBleu;
    }

    public void PeindreEnRouge()
    {
        GameObject.Find("Panel").GetComponent<Image>().color = CouleurRouge;
    }
}
