/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.ThirdPerson;

public class trump : MonoBehaviour
{
    Rigidbody rb;
    private bool jumpFlag = false;
    //GameObject playerObject = GameObject.FindWithTag("Player");
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //ThirdPersonController ScriptA = unityChan.GetComponent<ThirdPersonController>();
        //ThirdPersonController scriptA = unityChan.GetComponent<ThirdPersonController>();
        //CharacterController ScriptB = unityChan.GetComponent<CharacterController>();
        //rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        //ThirdPersonController thirdPersonController = playerObject.GetComponent<ThirdPersonCotroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpFlag)
        {
            rb.velocity = new Vector3(0, 10.0f, 0); 
            //rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
        }
    }

    void OnTriggerStay(Collider other)
    {
        jumpFlag = true;
        //unityChan.GetComponent<ThirdPersonController>().enabled = false;
        //unityChan.GetComponent<CharacterController>().enabled = false;
        //Invoke("OnTriggerEnter2D", 0.5f);
        //rb.isKinematic = false;
    }
    void OnTriggerExit(Collider other)
    {
        //unityChan.GetComponent<ThirdPersonController>().enabled = true;
        //unityChan.GetComponent<CharacterController>().enabled = true;
        //rb.isKinematic = true;
        jumpFlag = false;
    }


}
*/
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool jumpFlag = false;
    public GameObject unityChan;
    CharacterController characterController;
    private int i;

    void Start()
        {
            characterController = unityChan.GetComponent<CharacterController>();
        }

    private void OnTriggerEnter(Collider other)
    {
        
        // 衝突したオブジェクトがPlayerであるか確認
        if (other.CompareTag("Player"))
        {
            // ジャンプ台がPlayerと衝突したときの処理
            //CharacterController characterController = other.GetComponent<CharacterController>();

            if (characterController != null)
            {
                // ジャンプ台から上方向に力を加える
                jumpFlag = true;
                i=0;
            }
        }
    }

    void Update()
    {
        if(jumpFlag){
            i++;
            Vector3 jumpVector = Vector3.up * (jumpForce-i/2);
            characterController.Move(jumpVector/10);
            if(i>10)
            {
                jumpFlag = false;
            }
        }
    }
}
