using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSound : MonoBehaviour
{
    public float delay = 2.0f; //delay in seconds
    private void Start()
    {
        Destroy(gameObject, delay);
    }
}
