// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
//
// /**
//  * 
//  */
// public class CreatTre : MonoBehaviour
// {
//     public GameObject treasure;
//
//   
//
//
//     private GameObject tgame;
//     // Start is called before the first frame update
//     void Start()
//     {
//         InitTreasure();
//    
//     }
//
//     public void InitTreasure()
//     {
//         tgame = Instantiate(treasure);
//         tgame.transform.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
//         Vector3 treposition = new Vector3(-330, -2310, 0);
//         tgame.transform.SetParent(GameObject.Find("Content").transform);
//         tgame.transform.GetComponent<Transform>().localPosition = treposition;
//         tgame.transform.Find("buypic/buybut/Text").GetComponent<Text>().text = "5";
//         tgame.transform.Find("buypic/buybut/Image").GetComponent<Image>().sprite  = Resources.Load<Sprite>("DailySelection/coin/coin");
//         tgame.transform.Find("piccar").GetComponent<Image>().sprite = Resources.Load<Sprite>("Soldier/image/AEP_Atlas");
//     }
//
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
