using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float t = 0;
    public float a = 0.3f;
    public float Fr = 2;
    public float Off = 0;
    public Vector3 StartPos;
    // С какой скоростью должен двигаться объект

    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        t = t + Time.deltaTime;
        Off = a * Mathf.Sin (t * Fr);

        transform.position = StartPos + new Vector3(0, Off, 0); 
    }
}
