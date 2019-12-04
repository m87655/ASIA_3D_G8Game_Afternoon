﻿using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 1, E = 1;

    private void Start()
    {
        #region 數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        // 指派右邊先運算再給左邊
        C = 99 + 1;
        print(C);

        C = C + 1; // 原始寫法
        // 遞增、遞減 ++ --
        print(D++); // 後置遞增：先輸出再運算 - 看到 1 電腦內 2
        print(++E); // 前置遞增：先運算再輸出 - 看到 2 電腦內 2
        #endregion
    }
}