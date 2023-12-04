using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour
{
    public string next,now;
    public GameObject UI;
    
    // Start is called before the first frame update
    void Start()
    {
        UI.gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
       Debug.Log("衝突");      
       UI.SetActive(true);
    }

    public void sceneNext()
    {
        SceneManager.LoadScene(next);
    }

    public void sceneNow()
    {
        SceneManager.LoadScene(now);
    }
}