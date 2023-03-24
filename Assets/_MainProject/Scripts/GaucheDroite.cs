using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaucheDroite : MonoBehaviour
{
    private bool _detection = false;

    // [SerializeField] private GameObject _piege = default;
    [SerializeField] private float _vitesseGaucheDroite = 0.5f;

    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();


    private void Start()
    {
        this.transform.Translate(Vector3.left * _vitesseGaucheDroite);

        foreach (var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "left")
        {
            foreach (var gate in _listePieges)
            {
                gate.transform.Translate(Vector3.right * _vitesseGaucheDroite);
            }
        }
        else
        {
            foreach (var gate in _listePieges)
            {
                gate.transform.Translate(Vector3.left * _vitesseGaucheDroite);
            }
        }
    }
}
