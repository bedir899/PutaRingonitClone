using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public  Vector3 offset;

    public float lerpValue;


    private void Start()
    {
        offset.x = -0.42621f;
        offset.y = 3.39f;
        offset.z = -2.79f;
    }
    private void LateUpdate()
    {
        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
