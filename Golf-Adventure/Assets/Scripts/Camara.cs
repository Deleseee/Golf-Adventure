using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform camara;
    public float velocidad = 5f;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, camara.position, velocidad * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, camara.rotation, velocidad * Time.deltaTime);
    }
}
