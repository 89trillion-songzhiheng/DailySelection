using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * 更改购买状态
 */
public class buy : MonoBehaviour
{
    //购买前图标
    public GameObject beforshop;
    //购买后图标
    public GameObject aftershop;
    //对象按钮
    public Button button;
    // Start is called before the first frame update
    void Start()
    {

        beforshop.SetActive(true);
        aftershop.SetActive(false);
        button.onClick.AddListener(click);
    }

    public void click()
    {
        beforshop.SetActive(false);
        aftershop.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
