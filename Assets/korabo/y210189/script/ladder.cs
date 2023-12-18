using UnityEngine;

public class ladder : MonoBehaviour
{
    [TextArea(3, 10)] // 行数3から10までの複数行のテキストエリア
    public string multilineText = "はしごを2個以上連続で置く場合は、カプセルコライダーを全体で一つにしてください。カプセルコライダーの大きさは、使ってみて自分で修正してください。　カプセルコライダーのtriggerは外さないでください。";
}
