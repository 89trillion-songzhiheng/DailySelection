using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 修改宝箱花费的金币数
 */
public class Treasure : MonoBehaviour
{

    //宝箱
    public GameObject treasure;

    //宝箱按钮
    public Button button;
    
    //初始数值
    private int num = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        button.onClick.AddListener(ChangeNum);
    }
    

    public void ChangeNum()
    {
        if (num<15)
        {
            num = num + 5;
            treasure.transform.Find("buypic/buybut/Text").GetComponent<Text>().text = num.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
