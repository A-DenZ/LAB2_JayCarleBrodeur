using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs

    [SerializeField] private float _vitesse = 200;
    private Rigidbody _rb = null;

    private Vector3 jump;

    private float Movespeed = 3.5f;
    private float Jumpforce = 7.0f;
    private float Fallmultiplier = 2.0f;

    private bool onGround = true;

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(-43.5f, 3.14f, -45.87f);
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;
        }

    }

    private void Update()
    {
        this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Movespeed * Time.deltaTime);
        this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Movespeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround == true)
        {
            onGround = false;
            _rb.AddForce(Vector3.up * Jumpforce, ForceMode.VelocityChange);
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }


    public void ResetPlayerPosition()
    {
        this.transform.position = new Vector3(-43.5f, 3.14f, -45.87f);
    }







}
