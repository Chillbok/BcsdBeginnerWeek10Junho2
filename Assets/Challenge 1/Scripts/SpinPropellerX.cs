using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        gameObject.transform.Rotate(0, 0, rotateSpeed);
    }
}
