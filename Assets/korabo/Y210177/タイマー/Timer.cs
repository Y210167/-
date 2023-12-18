using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    bool timer_stop = true;
    bool reset = true;
    float elapasedTime;
    float slow;
    private void Start()
    {
        elapasedTime = 0;
        slow = 1.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer_stop)
        {
            if (Input.GetMouseButtonDown(1))
            {
                slow = 3.0f;
            }
            else if (Input.GetMouseButtonUp(1))
            {
                slow = 1.0f;
            }
            elapasedTime += (Time.deltaTime * slow);
            int hours = Mathf.FloorToInt(elapasedTime / (3600));
            int minutes = Mathf.FloorToInt(elapasedTime / 60);
            int seconds = Mathf.FloorToInt(elapasedTime % 60);
            int m_secomds = Mathf.FloorToInt((elapasedTime * 100) % 100);
            timerText.text = $"{hours:00}:{minutes:00}:{seconds:00}:{m_secomds:00}";
        }
        if (!reset)
        {
            if (Input.GetKey(KeyCode.R))
            {
                elapasedTime = 0;
                slow = 1.0f;
                timer_stop = true;
                reset = true;
                return;
            }
            if (Input.GetKey(KeyCode.Return))
            {
                elapasedTime = 0;
                slow = 1.0f;
                timer_stop = true;
                reset = true;
                return;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ÉSÅ[Éã");
            timer_stop = false;
            reset = false;
        }
    }
}
