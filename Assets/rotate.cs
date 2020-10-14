using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// kóði til að láta peninginn snúast
public class rotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f));
    }
}
