using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _pointage;

    private int _ObjectsToucheNiveau1 = 0;  
    private float _tempsNiveau1 = 0.0f;

    private int _ObjectsToucheNiveau2 = 0;
    private float _tempsNiveau2 = 0.0f;

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
        Debug.Log("------------Atteigner la porte le plus rapidement possible--------------");
        

    }

    public void SetNiveau1(int accrochages1, float tempsNiv1)
    {
        _ObjectsToucheNiveau1 = accrochages1;
        _tempsNiveau1 = tempsNiv1;
    }

    public float GetTempsNiv1()
    {
        return _tempsNiveau1;
    }

    public int GetObjectsToucheNiv1()
    {
        return _ObjectsToucheNiveau1;
    }

    public void SetNiveau2(int accrochages2, float tempsNiv2)
    {
        _ObjectsToucheNiveau2 = accrochages2;
        _tempsNiveau2 = tempsNiv2;
    }

    public float GetTempsNiv2()
    {
        return _tempsNiveau2;
    }

    public int GetObjectsToucheNiv2()
    {
        return _ObjectsToucheNiveau2;
    }
    
}
