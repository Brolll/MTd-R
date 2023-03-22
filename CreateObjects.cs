using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CreateObjects : MonoBehaviour
{
    private float oldY = 0f;
    public GameObject character;
    public GameObject fon;
    public GameObject enemy;
    public Vector3 charpos;


    private void FixedUpdate()
    {
        charpos = character.transform.position;
        Debug.Log(charpos);
        if (character.transform.position.y + 3 < oldY)
        {
            Instantiate(fon, charpos, Quaternion.identity);
            oldY = character.transform.position.y;
        }
        
        
    }
}
