using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public GameObject car;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - car.transform.position;
    }

    void Update()
    {
        transform.position = car.transform.position + mesafe;
    }
}
