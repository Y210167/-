using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityChanAttach : MonoBehaviour
{
   // public GameObject RootObject;
   bool Flag = false;
   private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Flag)
        {
            characterController.center = new Vector3(0,0.9f,0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 衝突したオブジェクトのタグが "Player" と一致するかを確認
        if (other.CompareTag("move_floor_side")){
            Debug.Log(other);
            Flag = true;
            this.gameObject.transform.parent = other.gameObject.transform;
            //characterController.center = new Vector3(0, 1, 0);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        // 衝突したオブジェクトのタグが "Player" と一致するかを確認
        if (other.CompareTag("move_floor_side")){
            Debug.Log(other);
            Flag = false;
            this.gameObject.transform.parent = null;
        }
    }
}
