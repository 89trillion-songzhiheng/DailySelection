using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//控制硬币的生成与移动
public class coinmove : MonoBehaviour
{

    //硬币对象
    public GameObject coin;
    
    //按钮
    public Button button;

    //获取按钮文本框，
    public Text txt;

    //存放上述按钮文本框的数据
    private string s;

    //控制update函数调用
    private bool cli = false;
    //生成硬币的预制件实例
    private GameObject gcon;

    //计算预制件生成个数
    private int sss = 0;

    //存放金币数
    private Text txtt;
    //获取当前生成金币最大数
    private int b=0;
    //获取当前生成金币最大数的上一个最大数
    private int pre = 0;

    //硬币预制件实例生成坐标
    private Vector3 treposition;
    //硬币预制件实例缩放数值
    private Vector3 localsca;
    //硬币预制件目标路径
    private Vector3 TragetPosition;
    // Start is called before the first frame update
    void Start()
    {
       
        //实例化硬币预制件的样本实例，后续实例预制件按照该实例的参数进行参数

        gcon  = Instantiate(coin);
        gcon.transform.SetParent(GameObject.Find("showshop").transform);
        TragetPosition = new Vector3(150, 30, 0);
        gcon.transform.GetComponent<Transform>().localPosition = new Vector3(-20, -300, 0);
       
        //获取样本缩放倍数
        float x = gcon.transform.GetComponent<Transform>().localScale.x - 3225.5f;
        float y = gcon.transform.GetComponent<Transform>().localScale.y - 3275.5f;
        gcon.transform.GetComponent<Transform>().localScale = new Vector3(x, y, 0);
        
        //样本数据获取后销毁该实例
        Destroy(gcon);
        
        //获取按钮文本，获取当前可生成金币的最大数
        s= txt.transform.GetComponent<Text>().text;
        pre = int.Parse(s);
        
        //初始化金币数
        txtt = GameObject.Find("number").GetComponent<Text>();
        txtt.text = "0";
        
        //初始化位置与缩放倍数
        treposition = new Vector3(-20, -300, 0);
        localsca = new Vector3(x, y, 0);
        
        button.onClick.AddListener(change);
         
    
    }


 
    public void change()
    {
        //获取按钮点击后的文本框数值
        s= txt.transform.GetComponent<Text>().text;
        b = int.Parse(s);
        
        // if (pre==5)
        // {
            //初始化预制件实例
            gcon  = Instantiate(coin);
            gcon.transform.SetParent(GameObject.Find("showshop").transform);
            gcon.SetActive(true);
            gcon.transform.GetComponent<Transform>().localPosition = treposition;
           gcon.transform.GetComponent<Transform>().localScale = localsca;

            GameObject.Find("number").GetComponent<Text>().text = (int.Parse(txtt.text) + pre).ToString();
            
            //调用update函数
            cli = true;
        
       
 }
 
 
    public void move()
    {

        if (gcon != null)
        {
            //控制硬币移动
            gcon.transform.localPosition = Vector3.MoveTowards(gcon.transform.localPosition,
                TragetPosition, 2.6f);
             //判断硬币是否到达目标地点
            if (gcon.transform.localPosition == TragetPosition)
            {
                //销毁到达目标地的实例
                Destroy(gcon);
                
                //达到允许生成的最大数，不再创建实例
                if (sss == pre - 1)
                {
                    gcon = null;

                    pre = b;
                    cli = false;
                    sss = 0;
                    enabled = false;
                }
                else
                {
                    Debug.Log(sss);

                    gcon = Instantiate(coin);
                    gcon.SetActive(true);
                    gcon.transform.SetParent(GameObject.Find("showshop").transform);
                    gcon.transform.GetComponent<Transform>().localPosition = treposition;
                    gcon.transform.GetComponent<Transform>().localScale = localsca;
                    sss++;
                }
            }


        }

    }
    

    // Update is called once per frame
    void Update()
    {
        if (cli)
        {
            Invoke("move",Time.deltaTime*1.9f);
        }
        
    }
}
