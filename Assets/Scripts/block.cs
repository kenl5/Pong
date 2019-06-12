using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public float delay = 3.0f;

    void Start()
    {
        Destroy(gameObject, delay);
    }
}
