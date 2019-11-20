using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法
    // 語法：
    // 修飾詞 傳回類型 方法名稱 () { 陳述式或演算法 }
    // void 無傳回
    // 需要被呼叫
    private void Drive()
    {
        // 輸出訊息(字串);
        print("開車，時速：200");
    }

    // 事件：在指定的時間會以指定次數執行的方法
    // 初始事件：遊戲播放後執行一次
    private void Start()
    {
        print("哈囉，沃德~");

        Drive();    // 呼叫自訂方法
        Drive();
    }
}
