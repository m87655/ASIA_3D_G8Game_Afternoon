using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;

    private void Start()
    {
        #region 數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);
        #endregion
    }
}
