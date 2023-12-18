using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFF_PL : MonoBehaviour
{
    public bool sw = true;
    public bool set = false;

    private void OnTriggerEnter(Collider other)
    {
        // 触れたオブジェクトがプレイヤーだったら実行
        if (other.gameObject.CompareTag("Player"))
        {
            if (!sw)
            {
                
                set = true;
                sw = true;
                return;
            }
            if (sw)
            {
                
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
