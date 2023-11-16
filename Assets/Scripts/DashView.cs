using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashView : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2.3f, 1.5f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
