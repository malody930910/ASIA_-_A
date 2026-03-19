using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // 宣告變數
    // 存取修飾詞 + 類型 + 變數名稱 {= 預設值};
    protected int number1 = 0;
    public float number2 = 0.3f;
    private bool ISfourEnterGame = true;

    // 非public存取修飾詞的變數，如果要顯示在Inspector中，則需要加上[SerializeField]
    [SerializeField] private int number3 = 0;
    [SerializeField] protected int number4 = 0;

    // 宣告方法
    // 存取修飾詞 + 方法回傳類型 + 方法名稱 (){}
    private void AddTwoNumber()
    {
        // 實作方法要做的事情
        print("顯示數值一加數值二的結果 : " + (number1 + number2));
    }
}
