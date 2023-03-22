using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.TextCore.Text;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float leftlimit;
    public float rightlimit;
    public float toplimit;


    private void FixedUpdate()
    {
        //Debug.Log(target.position.y);
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftlimit, rightlimit),
            target.transform.position.y,
            transform.position.z);
    }
}

