using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TP : MonoBehaviour
{
    private CharacterController a;
    public Vector3 warpPosition;
    //public Vector3 warpDirection;


    private void Start()
    {
        a = GetComponent<CharacterController>();
        warpPosition = new Vector3(0, 0, 0);
        //warpDirection = Vector3.up;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("save_1"))
        {
            warpPosition = new Vector3(10, 10, 10);
            //warpDirection = Vector3.up;
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            a = GetComponent<CharacterController>();
            Debug.Log("b");
            a.transform.position = new Vector3 (0, 0, 0);
            ///this.transform.rotation = Quaternion.LookRotation(warpDirection);
        }
    }
}
