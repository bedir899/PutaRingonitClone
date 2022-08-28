using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] public float rotateSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(rotateSpeed, 0,0 ) * Time.deltaTime);
    }
}
