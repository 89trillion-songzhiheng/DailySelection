using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 游戏开始界面
 */
public class game_start : MonoBehaviour
{

    //界面按钮
    public Button button;
    
    //初始界面
    public GameObject panel;
    
    //商品展示界面
    public GameObject showshop;
    // Start is called before the first frame update
    void Start()
    {
        showshop.SetActive(false);
        panel.SetActive(true);
        button.onClick.AddListener(click);
    }

    public void click()
    {
        showshop.SetActive(true);
        panel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
