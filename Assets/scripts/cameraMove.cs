//camera move
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ballTransform;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = ballTransform.position + offset;
    }
}