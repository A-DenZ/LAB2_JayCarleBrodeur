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
        if(indexScene == 0)
        {
            if (collision.gameObject.tag == "Player")
            {
                int erreurs = _gameManager.GetPointage();
                Debug.Log("Vous avez touché " + erreurs + " obstacles ");
                float total = Time.time + erreurs;
                Debug.Log("Temps Final : " + total + "Secondes");
                _player.FinPartie();


            }
        }
        else
        {
            SceneManager.LoadScene(indexScene+1);
        }
    }
}
