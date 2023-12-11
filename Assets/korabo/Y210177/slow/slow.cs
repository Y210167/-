using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        // コントロールキーが押されているかどうかをチェックします。
        if (Input.GetMouseButtonDown(1))
        {
            // コントロールキーが押された

            // タイムスケールをスローモーションにする
            Time.timeScale = 0.3f;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            // コントロールキーが離された

            // タイムスケールを元に戻す
            Time.timeScale = 1.0f;
        }
    }
}
