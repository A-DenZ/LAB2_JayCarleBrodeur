using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // Attributs 

    private GameManager _gameManager;
    private bool _toucher;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _toucher = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0);
                _gameManager.AugementerPointage();
                _toucher = true;
            }
        }
    }
}
