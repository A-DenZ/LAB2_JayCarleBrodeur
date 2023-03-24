using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs 

    private bool _detection = false;

    // [SerializeField] private GameObject _piege = default;

    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    [SerializeField] private float _intensiteForce = 500;
    private List<Rigidbody> _listeRb = new List<Rigidbody>();

    //private Rigidbody _rb;

    private void Start()
    {
        //_rb = _piege.GetComponent<Rigidbody>();
        //_rb.useGravity = false; 
        foreach (var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_detection)
        {
            foreach (var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);

            }


            //_rb.useGravity = true;
            //_rb.AddForce(Vector3.down * _intensiteForce);
            //_detection = true;
        }
    }
}
