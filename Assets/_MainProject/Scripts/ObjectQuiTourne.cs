using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectQuiTourne : MonoBehaviour
{
    [SerializeField] private float _vitesseRotationX = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_vitesseRotationX,0f , 0f);
    }
}
