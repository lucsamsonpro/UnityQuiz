using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TestScript_RandomRange : MonoBehaviour
{
    public int Nbr;
    List<int> Memory = new List<int>();

    void OnMouseDown()
    {
        if (Memory.Count == 10)
        {
            Debug.Log("La liste est pleine !");
        }
        else
        {
            Nbr = Random.Range(0, 10);
            Debug.Log("N° tiré : " + Nbr);
            while (Memory.Contains(Nbr))
            {
                Debug.Log("N° déjà tiré, recommencez !");
                Nbr = Random.Range(0, 10);
                Debug.Log("N° tiré : " + Nbr);
            }
            Memory.Add(Nbr);
            Debug.Log("N° " + Nbr + " ajouté à la liste !");
            if (Memory.Count == 1)
            {
                Debug.Log("La liste contient maintenant " + Memory.Count + " élément.");
            }
            else
            {
                Debug.Log("La liste contient maintenant " + Memory.Count + " éléments.");
            }
        }
    }

    public void NewRandomNbr()
    {
        Nbr = Random.Range(0, 10);
        Debug.Log("N° tiré : " + Nbr);
        while (Memory.Contains(Nbr))
        {
            Debug.Log("N° déjà tiré, recommencez !");
            Nbr = Random.Range(0, 10);
            Debug.Log("N° tiré : " + Nbr);
        }
        Memory.Add(Nbr);
        Debug.Log("N° " + Nbr + " ajouté à la liste !");
        if (Memory.Count == 1)
        {
            Debug.Log("La liste contient maintenant " + Memory.Count + " élément.");
        }
        else
        {
            Debug.Log("La liste contient maintenant " + Memory.Count + " éléments.");
        }

    }
        
        
    

}
