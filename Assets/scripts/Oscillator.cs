using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The component will move the object in oscillator way */
public class Oscillator: MonoBehaviour
{
    [SerializeField]
    public float delta;  // Amount to move left and right from the start point
    [SerializeField]
    public float speed;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        delta= Random.Range(2.0f, 4f);
        speed= Random.Range(1.0f, 4f);
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
