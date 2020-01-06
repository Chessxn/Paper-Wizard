using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExplosionDelay : MonoBehaviour
{
    public float shrinkAmount = 0.1f;
    public float shrinkTime = 2.0f;

    private void Shrink()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale * shrinkAmount, shrinkTime);
    }

    private void Start()
    {
        Shrink();
        Destroy(gameObject, shrinkTime);
    }
}
