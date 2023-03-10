using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs

    [SerializeField] private float _vitesse = 200;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(47.27f, 3f, -44.26f);
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        //transform.Translate(direction * Time.deltaTime * _vitesse);
    }
}
