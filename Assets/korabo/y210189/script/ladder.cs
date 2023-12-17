/*using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float climbSpeed = 2f; // 梯子を登る速さ
    private CharacterController characterController;
    private bool isOnLadder = false;
    //private GameObject Player;

    void Start()
    {
        GameObject Player = GameObject.Find("unitychan_dynamic");
        characterController = Player.GetComponent<CharacterController>();
    }

    void Update()
    {
        // 梯子に触れているかどうかの判定
        if (isOnLadder)
        {
            //Debug.Log("a");
            // 上下の入力を取得
            if(Input.GetKey(KeyCode.L)){
                // 移動ベクトルの作成（上方向に移動）
                Vector3 moveDirection = new Vector3(0, climbSpeed, 0);
                moveDirection = transform.TransformDirection(moveDirection);
                Debug.Log("a");
                // 梯子の上昇
                characterController.Move(moveDirection * climbSpeed * Time.deltaTime);
            }
        }
    }

    // 梯子に触れたときに呼ばれるメソッド
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("b");
        if (other.CompareTag("Player"))
        {
            isOnLadder = true;
        }
    }

    // 梯子から離れたときに呼ばれるメソッド
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnLadder = false;
        }
    }
}

*/