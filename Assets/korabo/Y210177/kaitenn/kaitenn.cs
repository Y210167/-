using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaitenn : MonoBehaviour
{
    public void Update()
    {
        GameObject[] kaitenn_x = GameObject.FindGameObjectsWithTag("skeleton_ON");
        foreach (GameObject k_x in kaitenn_x)
        {
            Collider k_x_collider = k_x.GetComponent<Collider>();
            
        }
    }
}