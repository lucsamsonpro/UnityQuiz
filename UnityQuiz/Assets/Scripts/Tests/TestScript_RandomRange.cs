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
            Debug.Log("N� tir� : " + Nbr);
            while (Memory.Contains(Nbr))
            {
                Debug.Log("N� d�j� tir�, recommencez !");
                Nbr = Random.Range(0, 10);
                Debug.Log("N� tir� : " + Nbr);
            }
            Memory.Add(Nbr);
            Debug.Log("N� " + Nbr + " ajout� � la liste !");
            if (Memory.Count == 1)
            {
                Debug.Log("La liste contient maintenant " + Memory.Count + " �l�ment.");
            }
            else
            {
                Debug.Log("La liste contient maintenant " + Memory.Count + " �l�ments.");
            }
        }
    }

    public void NewRandomNbr()
    {
        Nbr = Random.Range(0, 10);
        Debug.Log("N� tir� : " + Nbr);
        while (Memory.Contains(Nbr))
        {
            Debug.Log("N� d�j� tir�, recommencez !");
            Nbr = Random.Range(0, 10);
            Debug.Log("N� tir� : " + Nbr);
        }
        Memory.Add(Nbr);
        Debug.Log("N� " + Nbr + " ajout� � la liste !");
        if (Memory.Count == 1)
        {
            Debug.Log("La liste contient maintenant " + Memory.Count + " �l�ment.");
        }
        else
        {
            Debug.Log("La liste contient maintenant " + Memory.Count + " �l�ments.");
        }

    }
        
        
    

}
