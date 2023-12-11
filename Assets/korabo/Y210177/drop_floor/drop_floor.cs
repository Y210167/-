using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_floor : MonoBehaviour
{
    // 点滅の状態
    private bool isBlinking = false;
    // 実行中
    private bool Running = true;
    // 落ちる状態
    private bool isFalling = false;
    // 元の色
    public Color originColor;
    // 元の位置
    public Vector3 originPosition;
    // 元の回転
    public Quaternion originRotation;

    private BoxCollider boxCol;

    public void Start()
    {
        // オブジェクトの色と位置を格納
        originColor = GetComponent<Renderer>().material.color;
        originPosition = transform.position;
        originRotation = transform.rotation;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        // 触れたオブジェクトがプレイヤーだったら実行
        if (other.gameObject.CompareTag("Player"))
        {
            isBlinking = true;
            if (isBlinking && Running)
            {
                StartCoroutine(drop());
                Running = false;
            }
        }
            
        
    }

    IEnumerator drop()
    {
        if (isBlinking)
        {
            // 何回点滅させるか
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(i);
                GetComponent<Renderer>().material.color = Color.red;
                yield return new WaitForSeconds(0.2f);
                GetComponent<Renderer>().material.color = originColor;
                yield return new WaitForSeconds(0.2f);
                if (i == 2)
                {
                    Debug.Log("点滅終了");
                    isBlinking = false;
                    isFalling = true;
                }
            }
        }

        if (isFalling)
        {
            // 点滅が終わったら実行
            Debug.Log("落ちるー");
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            boxCol = gameObject.GetComponent<BoxCollider>();
            // キネマティックをfarceにしてオブジェクトが落下するようにする
            rigidbody.isKinematic = false;

            boxCol.enabled = false;
            // 何秒後に元の位置に戻すか
            yield return new WaitForSeconds(10.0f);
            // キネマティックを戻す
            rigidbody.isKinematic = true;
            transform.position = originPosition;
            transform.rotation = originRotation;
            boxCol.enabled = true;
            Running = true;
            isFalling = false;
        }
        
    }
}
