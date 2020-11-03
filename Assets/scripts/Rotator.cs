using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* The component will do rotation around itself  */
public class Rotator : MonoBehaviour
{
    [SerializeField]
    public float x=0f;
    [SerializeField]
    public float y = 0f;
    [SerializeField]
    public float z = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x, y, z));
    }
}
