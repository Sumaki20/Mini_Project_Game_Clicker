using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour
{
    public float rotateSpeed = 0.1f;
    public GameObject cube2;

    void Update()
    {
        cube2.transform.Rotate(rotateSpeed, 0.0f, 0.0f);
    }
}
