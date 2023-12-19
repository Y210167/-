using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TP : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 warpPosition;
    private bool isWarping = false;

    void Start()
    {
        // (0, 0, 0) (-13, 34, 18) (20, 50 ,24) (6, 87, 48)
        controller = GetComponent<CharacterController>();
        warpPosition = new Vector3(0, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("save_point"))
        {
            Debug.Log(warpPosition);
            warpPosition = other.transform.position;
            warpPosition.y += 0.05f;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isWarping = true;
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            isWarping = false;
        }

        if (isWarping)
        {
            controller.transform.position = warpPosition;
        }
    }
}
