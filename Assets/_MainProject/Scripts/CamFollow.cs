using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    [SerializeField] Transform target;
    Vector3 offsetCamera;

    void Start()
    {
        offsetCamera = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraposition = target.position + offsetCamera;
        transform.position = cameraposition;
    }
}
