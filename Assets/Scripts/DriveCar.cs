using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    public float speed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
