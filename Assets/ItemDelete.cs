using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;

    //coinPrefab������
    public GameObject coinPrefab;

    //cornPrefab������
    public GameObject conePrefab;

    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //�X�^�[�g�n�_
   // private int startPos = 80;
    //�S�[���n�_
    //private int goalPos = 360;


    // Start is called before the first frame update
    void Start()
    {

        //Unity�����̃I�u�W�F�N�g���擾
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
