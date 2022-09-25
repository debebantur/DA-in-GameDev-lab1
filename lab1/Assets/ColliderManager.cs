using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " ON");
        other.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " OFF");
        other.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
