using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 當玩家按下A鍵時，執行這裡的程式碼
            this.transform.position= this.transfrom,position+ new Vector3(-1,0,0)*(speed*Time.deltaTime))
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            // 當玩家按下D鍵時，執行這裡的程式碼
        }
    }
}
