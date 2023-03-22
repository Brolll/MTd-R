using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{    


    public Rigidbody2D rb;
    private Vector2 moveinput;
    public GameObject character;
    private Vector3 rotation;
    public float leftlimit;
    public float rightlimit;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(character);
    }

    void Start()
    {
        rotation = character.transform.rotation.eulerAngles;
    }

    private void FixedUpdate()
    {
        character.transform.rotation = Quaternion.Euler(rotation);
        rotation.z += 2;
        if (rotation.z == 360)
            rotation.z = -360;

    }
}
