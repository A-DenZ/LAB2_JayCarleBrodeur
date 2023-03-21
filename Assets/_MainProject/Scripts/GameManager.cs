using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _pointage;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GameManager>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        _pointage= 0;
        Instructions();
    }

    void Update()
    {
        
    }

    public void AugementerPointage()
    {
        _pointage++;
    }
    public int GetPointage()
    {
        return _pointage;
    }

    private static void Instructions()
    {
        Debug.Log("------------Bienvenue dans La Légende du petit Chevalier--------------");
        Debug.Log("                      ------------Niveau 1 --------------");
        Debug.Log("------------Atteigner la porte le plus rapidement possible--------------");
        Debug.Log("------------Attention la lave est brûlante n'y touché pas!--------------");

    }

}
