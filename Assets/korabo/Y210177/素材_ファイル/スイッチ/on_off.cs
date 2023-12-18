using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_off : MonoBehaviour
{
    public bool sw = true;
    public bool set = true;

    public void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // 触れたオブジェクトがプレイヤーだったら実行
        if (other.gameObject.CompareTag("Player"))
        {
            if (!sw)
            {
                GameObject[] Switch = GameObject.FindGameObjectsWithTag("Switch");
                Debug.Log("ON");
                foreach (GameObject playerObject in Switch)
                {
                    playerObject.GetComponent<Renderer>().material.color = Color.red;
                    playerObject.transform.rotation = Quaternion.identity;
                }
                set = true;
                sw = true;
                return;
            }
            if (sw)
            {
                GameObject[] Switch = GameObject.FindGameObjectsWithTag("Switch");
                Debug.Log("OFF");
                foreach (GameObject playerObject in Switch)
                {
                    playerObject.GetComponent<Renderer>().material.color = Color.blue;
                    playerObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                set = true;
                sw = false;
            }
        }
    }
    public void Update()
    {
        if (set)
        {
            // ONの時
            if (!sw)
            {
                GameObject[] skeleton_ON = GameObject.FindGameObjectsWithTag("skeleton_ON");
                foreach (GameObject s_on in skeleton_ON)
                {
                    s_on.GetComponent<Renderer>().material.color = new Color(1f, 0f, 0f, 0.5f);
                    Collider s_on_collider = s_on.GetComponent<Collider>();
                    s_on_collider.enabled = false;
                }

                GameObject[] skeleton_OFF = GameObject.FindGameObjectsWithTag("skeleton_OFF");
                foreach (GameObject s_off in skeleton_OFF)
                {
                    s_off.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 1f);
                    Collider s_off_collider = s_off.GetComponent<Collider>();
                    s_off_collider.enabled = true;
                }
                // ここにONの時にどういう処理をしたいか書けばいい

            }
            // OFFの時
            if (sw)
            {
                GameObject[] skeleton_ON = GameObject.FindGameObjectsWithTag("skeleton_ON");
                foreach (GameObject s_on in skeleton_ON)
                {
                    s_on.GetComponent<Renderer>().material.color = new Color(1f, 0f, 0f, 1f);
                    Collider s_on_collider = s_on.GetComponent<Collider>();
                    s_on_collider.enabled = true;
                }

                GameObject[] skeleton_OFF = GameObject.FindGameObjectsWithTag("skeleton_OFF");
                foreach (GameObject s_off in skeleton_OFF)
                {
                    s_off.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 0.5f);
                    Collider s_off_collider = s_off.GetComponent<Collider>();
                    s_off_collider.enabled = false;
                }
                // ここにOFFの時にどういう処理をしたいか書けばいい

            }
            set = false;
        }
        
    }
}
