using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private GameManager _gameManager;
    private Player _player;


    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if(indexScene == 2)
        {
            if (collision.gameObject.tag == "Player")
            {
                int ObjectsTouche = _gameManager.GetPointage();  // Récupère le pointage total
                


                float tempsTotNiv1 = _gameManager.GetTempsNiv1() + _gameManager.GetObjectsToucheNiv1(); // le temps total pour le niveau 1

                float _tempsNiveau2 = _gameManager.GetTempsNiv2() - _gameManager.GetTempsNiv1();  // le temps pour le niveau 2

                int _ObjectsToucheNiv2 = _gameManager.GetObjectsToucheNiv2() - _gameManager.GetObjectsToucheNiv1(); // donne le nombre d'objects touché au niveau 2
                float tempsTotNiv2 = _tempsNiveau2 + _ObjectsToucheNiv2; // donne temps total du niveau 2

                int _ObjectsToucheNiv3 = ObjectsTouche - _ObjectsToucheNiv2; // donne le nombre d'objects touché au niveau 3
                float _tempsNiveau3 = Time.time - tempsTotNiv2;  // donne le temps du niveau 3
                float _tempsTotNiv3 = _tempsNiveau3 + _ObjectsToucheNiv3; // donne le temps total du niveau 3

                float _TempsTotal= Time.time + _ObjectsToucheNiv3 + _ObjectsToucheNiv2 + _gameManager.GetObjectsToucheNiv1() ; //Récupère le temps total ; 

                Debug.Log("Fin de partie !!!!");
                Debug.Log("Le temps pour le niveau 1 est de : " + _gameManager.GetTempsNiv1().ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché : " + _gameManager.GetObjectsToucheNiv1() + " obstacles au niveau 1 ");
                Debug.Log("Temps total niveau 1 : " + tempsTotNiv1.ToString("f2") + " secondes");
                Debug.Log("Le temps pour le niveau 2 est de : " + _tempsNiveau2.ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché : " + _ObjectsToucheNiv2 + " obstacles au niveau 2 ");
                Debug.Log("Temps total niveau 2 : " + tempsTotNiv2.ToString("f2") + " secondes");
                Debug.Log("Le temps pour le niveau 3 est de : " + _tempsNiveau3.ToString("f2") + " secondes");
                Debug.Log("Vous avez accroché : " + _ObjectsToucheNiv3 + " obstacles au niveau 3 ");
                Debug.Log("Temps total niveau 3 : " + _tempsTotNiv3.ToString("f2") + " secondes");
                Debug.Log("Le temps total pour les trois niveau est de : " + (_TempsTotal).ToString("f2") + " secondes");
                _player.FinPartie();


            }
        }
        else if(indexScene == 1)
        {
            _gameManager.SetNiveau2(_gameManager.GetPointage(), Time.time);
            SceneManager.LoadScene(indexScene+1);
        }
        else 
        {
            _gameManager.SetNiveau1(_gameManager.GetPointage(), Time.time);
            SceneManager.LoadScene(indexScene + 1);
        }
    }


    public int GetSceneManager()
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        return indexScene;
    }


}
