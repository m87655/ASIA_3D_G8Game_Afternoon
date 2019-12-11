using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // 非靜態
    // 變形、剛體、動畫、音效、燈光、攝影機
    // 先定義欄為存放並設定代號
    // 修飾詞 類型 名稱(代號)
    public Transform test1;

    private void Start()
    {
        // 取得非靜態屬性
        // 代號.屬性
        print(test1.position);
    }
}
