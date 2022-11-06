using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideColorChanger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        
        GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }
}
