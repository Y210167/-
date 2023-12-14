using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{
    public string next,now,start;
    public GameObject UI;
    private bool clear = false;
    
    // Start is called before the first frame update
    void Start()
    {
        clear = false;
        UI.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if(clear)
        {
            if (Input.GetKey (KeyCode.R))
            {
                Debug.Log("a");
                sceneNow();
            }
            if (Input.GetKey (KeyCode.Return))
            {
                Debug.Log("b");
                sceneNext();
            }
        }
        if(Input.GetKey(KeyCode.S) && SceneManager.GetActiveScene().name == "startScene")
            {
                sceneStart();
            }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("トリガーされました");
        UI.SetActive(true);
        clear = true;
    }

    public void sceneNext()
    {
        SceneManager.LoadScene(next);
    }

    public void sceneNow()
    {
        SceneManager.LoadScene(now);
    }

    public void sceneStart()
    {
        SceneManager.LoadScene(start);
    }
}