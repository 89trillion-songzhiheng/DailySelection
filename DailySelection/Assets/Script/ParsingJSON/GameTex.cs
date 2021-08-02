using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;
using UnityEngine.UI;


/**
 * 卡片生成界面
 */
        
public class GameTex : MonoBehaviour
 {

     //卡片对象
     public GameObject crad;
     
     //空卡对象
     public GameObject lose;
     
     //存放json文件中的数据
     private  string moveSpriet;
     
     //获取json文件
     public TextAsset txt;
     
     private string s;
     
     //获取卡片数量，用于计算卡片横坐标
     int xspe = 0;
     //获取卡片数量，用于计算卡片纵坐标
     int yspe = 0;
  
     void Start ()
     {
                
         moveSpriet=txt.text;
         InitTextList();
         // InitTitle();
     }
        
            
     public  void InitTextList ()
     {
         //将json数据格式化
         var n = JSONNode.Parse (moveSpriet);
         JSONArray npc=n[0].AsArray;
         
         //循环读取json数据
         foreach (JSONNode bBox in npc)
         {
             GameObject gameObject=   Instantiate(crad);
             gameObject.transform.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
             Vector3 position = new Vector3((2*(xspe%3)*180)-350,-(710+(yspe/3)*670),0);
             gameObject.transform.SetParent(GameObject.Find("Content").transform);
                    
             gameObject.GetComponent<Transform>().localPosition = position;
             gameObject.GetComponent<Transform>().localScale = new Vector3(1.2f, 1.2f, 1f);
             int y = bBox["type"];
             int xx = bBox["costGold"];
             string zz = bBox["subType"].ToString();
         
             //判断图片是否为空
             if (bBox["subType"] == null)
             { 
                 gameObject.transform.Find("buypic/buybut/Text").GetComponent<Text>().text = xx.ToString();
                 gameObject.transform.Find("buypic/buybut/Image").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/diamond/diamond_2");
                 gameObject.transform.Find("piccar").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/card/Angel");
             }
             else
             {
                        
                 //判断货币类型
                 if ( y==3)
                 {
                     gameObject.transform.Find("buypic/buybut/Text").GetComponent<Text>().text = xx.ToString();
                     gameObject.transform.Find("buypic/buybut/Image").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/coin/coin");
                     gameObject.transform.Find("piccar").GetComponent<Image>().sprite = Resources.Load<Sprite>("DailySelection/card/"+zz+"");
                 }
                    
                   
                 if (y == 2)
                 { 
                     gameObject.transform.Find("buypic/buybut/Text").GetComponent<Text>().text = xx.ToString();
                     gameObject.transform.Find("buypic/buybut/Image").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/diamond/diamond_2");
                     gameObject.transform.Find("piccar").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/card/"+zz+"");
                 }
                    
                        
             }
                    
             xspe++;
             yspe++;
         }
         
         //卡片数量不够3的倍数，进行补缺
         int ab = npc.Count % 3;
         if (ab !=0)
         {
             for (int i = 0; i < (3-ab); i++)
             {
                 GameObject gameObject=   Instantiate(lose);
                 gameObject.transform.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
                 // Debug.Log(xx);
                 Vector3 position = new Vector3((2*(xspe%3)*180)-350,-(710+(yspe/3)*670),0);
                 gameObject.transform.SetParent(GameObject.Find("Content").transform);
                 gameObject.GetComponent<Transform>().localPosition = position;
                 gameObject.GetComponent<Transform>().localScale = new Vector3(1.2f, 1.2f, 1f);
                 gameObject.transform.Find("lose").GetComponent<Image>().sprite = Resources.Load<Sprite>("DailySelection/card/shop_lock");
                 xspe++;
                 yspe++;
             }
         }
     }
     
}
        