using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_floor_front : MonoBehaviour
{
    public float length = 2f;

    private Rigidbody rb;
    private Vector3 Pos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Pos = transform.position;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(new Vector3(Pos.x, Pos.y + Mathf.PingPong(Time.time, length), Pos.z + Mathf.PingPong(Time.time, length)));
    }
}
