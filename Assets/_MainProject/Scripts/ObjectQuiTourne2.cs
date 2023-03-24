using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectQuiTourne2 : MonoBehaviour
{
    [SerializeField] private float _vitesseRotationY = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_vitesseRotationY, 0f, 0f);
    }
}
