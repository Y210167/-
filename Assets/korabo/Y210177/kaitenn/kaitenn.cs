using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaitenn : MonoBehaviour
{
    public void Update()
    {
        GameObject[] kaitenn_x = GameObject.FindGameObjectsWithTag("kaiten_x");
        foreach (GameObject k_x in kaitenn_x)
        {
            Collider k_x_collider = k_x.GetComponent<Collider>();
            k_x_collider.transform.Rotate(Vector3.up, 1);
            Debug.Log("kaitenn");
        }
        GameObject[] kaitenn_y = GameObject.FindGameObjectsWithTag("kaiten_y");
        foreach (GameObject k_y in kaitenn_y)
        {
            Collider k_y_collider = k_y.GetComponent<Collider>();
            k_y_collider.transform.Rotate(Vector3.right, 1);
            Debug.Log("kaitenn");
        }
        GameObject[] kaitenn_z = GameObject.FindGameObjectsWithTag("kaiten_z");
        foreach (GameObject k_z in kaitenn_z)
        {
            Collider k_z_collider = k_z.GetComponent<Collider>();
            k_z_collider.transform.Rotate(Vector3.forward, 1);
            Debug.Log("kaitenn");
        }


        GameObject[] kaiten_x_minus = GameObject.FindGameObjectsWithTag("kaiten_x_minus");
        foreach (GameObject k_x_m in kaiten_x_minus)
        {
            Collider k_x_m_collider = k_x_m.GetComponent<Collider>();
            k_x_m_collider.transform.Rotate(Vector3.up, 1);
            Debug.Log("kaitenn");
        }
        GameObject[] kaitenn_y_minus = GameObject.FindGameObjectsWithTag("kaiten_y_minus");
        foreach (GameObject k_y_m in kaitenn_y_minus)
        {
            Collider k_y_m_collider = k_y_m.GetComponent<Collider>();
            k_y_m_collider.transform.Rotate(Vector3.right, 1);
            Debug.Log("kaitenn");
        }
        GameObject[] kaitenn_z_minus = GameObject.FindGameObjectsWithTag("kaiten_z_minus");
        foreach (GameObject k_z_m in kaitenn_z_minus)
        {
            Collider k_z_collider = k_z_m.GetComponent<Collider>();
            k_z_collider.transform.Rotate(Vector3.forward, 1);
            Debug.Log("kaitenn");
        }
    }
}