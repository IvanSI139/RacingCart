using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventFlip : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass += new Vector3(0, -1f, 0);
    }
}
