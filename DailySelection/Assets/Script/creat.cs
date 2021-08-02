// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
//
// public class creat : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
//         initCard();
//   
//     }
//
//
//     public void initCard()
//     {
//         GameObject m_testImage = new GameObject("coin");
//         m_testImage.transform.SetParent(GameObject.Find("Content").transform);
//         m_testImage.AddComponent<Image>();
//         //动态加载贴图赋值给Image
//         // m_testImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("DailySelection/coin/coin");
//         //这里将图片变成黑色而且改变透明度为50%
//         // m_testImage.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f);
//         //修改位置       
//         // m_testImage.GetComponent<RectTransform>().anchoredPosition = new Vector2(0.0f, 100.0f);
//         //修改旋转
//         // m_testImage.GetComponent<RectTransform>().localRotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
//         //修改缩放
//         // m_testImage.GetComponent<RectTransform>().localScale = new Vector3(1.2f, 1.2f, 1.2f);
//         //修改大小
//         m_testImage.GetComponent<RectTransform>().sizeDelta = new Vector2(322.0f, 594.0f);
//
//     }
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
