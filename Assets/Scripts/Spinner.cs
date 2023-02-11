using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRotation = 0;
    [SerializeField] float yRotation = 0;
    [SerializeField] float zRotation = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
