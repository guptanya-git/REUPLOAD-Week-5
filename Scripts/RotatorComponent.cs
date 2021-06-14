using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorComponent : MonoBehaviour
{
    [SerializeField]
    //the axis around which the gameobject is rotating
    private Vector3 rotationAxis = Vector3.up;
    //the speed with which the gameobject is rotating in degrees/frame
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);   
    }
}
