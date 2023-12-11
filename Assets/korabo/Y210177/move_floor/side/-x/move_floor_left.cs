using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_floor_left : MonoBehaviour
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
        rb.MovePosition(new Vector3(Pos.x - Mathf.PingPong(Time.time, length), Pos.y, Pos.z));
    }
}
