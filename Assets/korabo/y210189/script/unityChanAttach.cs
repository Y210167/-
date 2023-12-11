using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityChanAttach : MonoBehaviour
{
   // public GameObject RootObject;
   bool Flag = false;
   private CharacterController characterController;
   Vector3 currentPosition;
   public float adjust=0.3f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0 || Input.GetKey("space"))
        {
            currentPosition = transform.localPosition;
            Flag = false;
        }
    }

    void FixedUpdate()
    {
        if(Flag){  
            currentPosition.y = transform.localPosition.y-adjust;
            characterController.transform.localPosition = currentPosition;
        }
    }

    void OnTriggerStay(Collider other)
    {
        // 衝突したオブジェクトのタグが "Player" と一致するかを確認
        if ((other.CompareTag("move_floor_side")) && (Input.GetAxis("Horizontal")==0 && Input.GetAxis("Vertical")==0)){
            Debug.Log(other);
            this.gameObject.transform.parent = other.gameObject.transform;
            currentPosition = transform.localPosition;
            Flag = true;
            
           
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
