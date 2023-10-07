using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetected : MonoBehaviour
{
    private Color _prevColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Material mat = other.gameObject.GetComponent<MeshRenderer>().material;
            _prevColor = mat.color;
            mat.color = Color.blue;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Material mat = other.gameObject.GetComponent<MeshRenderer>().material;
            mat.color = _prevColor;
        }
    }
}