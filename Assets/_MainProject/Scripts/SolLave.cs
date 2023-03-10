using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolLave : MonoBehaviour
{
    [SerializeField] private float _vitesseSolY = 0.5f;

    private Player unPlayer;

    // Start is called before the first frame update
    void Start()
    {
        unPlayer = FindObjectOfType<Player>();
        this.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    private void  FixedUpdate()
    {
        this.transform.Translate(Vector3.up* _vitesseSolY);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            unPlayer.ResetPlayerPosition();
            ResetPositionSol();
            Debug.Log("touché");

        }
        
    }

    private void ResetPositionSol()
    {
        this.transform.position = new Vector3(0f, 0f, 0f);
    }

}
