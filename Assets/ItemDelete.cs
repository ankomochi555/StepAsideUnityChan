using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;

    //coinPrefabを入れる
    public GameObject coinPrefab;

    //cornPrefabを入れる
    public GameObject conePrefab;

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //スタート地点
   // private int startPos = 80;
    //ゴール地点
    //private int goalPos = 360;


    // Start is called before the first frame update
    void Start()
    {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {

            if (this.unitychan.transform.position.z - this.transform.position.z > 6f)
        {

            Destroy(this.gameObject);

        }
        

    }
}
