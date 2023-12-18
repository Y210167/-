using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kirikae_floor : MonoBehaviour
{
    public Color originColor_a;
    public Color originColor_a_h;

    public Color originColor_b;
    public Color originColor_b_h;

    public bool kurikaesi = true;

    private float _timeElapsed;   //経過時間

    private float tennmetu = 4;   //点滅する間隔



    private void Start()
    {
        GameObject[] kirikae_a = GameObject.FindGameObjectsWithTag("kirikae_a");
        GameObject[] kirikae_b = GameObject.FindGameObjectsWithTag("kirikae_b");
        foreach (GameObject k_a in kirikae_a)
        {
            originColor_a = k_a.GetComponent<Renderer>().material.color;
        }
        foreach (GameObject k_b in kirikae_b)
        {
            originColor_b = k_b.GetComponent<Renderer>().material.color;
        }
        originColor_a_h = originColor_a;
        originColor_a_h.a /= 2;

        originColor_b_h = originColor_b;
        originColor_b_h.a /= 2;

        foreach (GameObject k_b in kirikae_b)
        {
            k_b.GetComponent<Renderer>().material.color = originColor_b_h;
        }
    }

    private void Update()
    {
        GameObject[] kirikae_a = GameObject.FindGameObjectsWithTag("kirikae_a");
        GameObject[] kirikae_b = GameObject.FindGameObjectsWithTag("kirikae_b");
        _timeElapsed += Time.deltaTime;     //時間をカウントする

        //経過時間が繰り返す間隔を経過したら
            if (_timeElapsed >= tennmetu - 0.9)
        {
            //ここで処理を実行
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = Color.red;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = Color.red;
            }

        }
        if (_timeElapsed >= tennmetu - 0.75)
        {
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = originColor_a;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = originColor_b;
            }
        }
        if (_timeElapsed >= tennmetu - 0.6)
        {
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = Color.red;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = Color.red;
            }
        }
        if (_timeElapsed >= tennmetu - 0.45)
        {
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = originColor_a;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = originColor_b;
            }
        }
        if (_timeElapsed >= tennmetu - 0.3)
        {
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = Color.red;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = Color.red;
            }
        }
        if (_timeElapsed >= tennmetu - 0.15)
        {
            foreach (GameObject k_a in kirikae_a)
            {
                k_a.GetComponent<Renderer>().material.color = originColor_a;
            }
            foreach (GameObject k_b in kirikae_b)
            {
                k_b.GetComponent<Renderer>().material.color = originColor_b;
            }
        }
        if (_timeElapsed >= tennmetu)
        {
            if (kurikaesi)
            {
                foreach (GameObject k_a in kirikae_a)
                {
                    k_a.GetComponent<Renderer>().material.color = originColor_a_h;
                    Collider k_a_collider = k_a.GetComponent<Collider>();
                    k_a_collider.enabled = false;
                }
                foreach (GameObject k_b in kirikae_b)
                {
                    k_b.GetComponent<Renderer>().material.color = originColor_b;
                    Collider k_b_collider = k_b.GetComponent<Collider>();
                    k_b_collider.enabled = true;
                }
                kurikaesi = false;
                _timeElapsed = 0;
                Debug.Log("1");
                return;
            }
            if (!kurikaesi)
            {
                foreach (GameObject k_a in kirikae_a)
                {
                    k_a.GetComponent<Renderer>().material.color = originColor_a;
                    Collider k_a_collider = k_a.GetComponent<Collider>();
                    k_a_collider.enabled = true;
                }
                foreach (GameObject k_b in kirikae_b)
                {
                    k_b.GetComponent<Renderer>().material.color = originColor_b_h;
                    Collider k_b_collider = k_b.GetComponent<Collider>();
                    k_b_collider.enabled = false;
                }
                kurikaesi = true;
                _timeElapsed = 0;
                Debug.Log("2");
            }
        }
    }
}