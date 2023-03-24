using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs

    [SerializeField] private float _vitesse = 3.5f;
    private Rigidbody _rb = null;

    private Vector3 jump;

    private float Jumpforce = 8.0f;
    private float Fallmultiplier = 2.0f;

    private bool onGround = true;

    private GestionFin thisfin; 
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animator>().enabled = false;
        this.transform.position = new Vector3(0.953000009f, 0.69f, -52.4300003f);
        jump = new Vector3(0.0f, 4.0f, 0.0f);
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * _vitesse * Time.fixedDeltaTime);
        this.transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * _vitesse * Time.fixedDeltaTime);

        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;
        }

    }

    private void Update()
    {


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

    public void FinPartie()
    {
        this.gameObject.SetActive(false);
    }





}
