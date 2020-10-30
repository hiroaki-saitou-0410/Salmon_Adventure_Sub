using RunGame.Stage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPfactory : MonoBehaviour
{
    public GameObject HPgauge=null;
    public GameObject Player;
    GameObject[] Hp;
    int HP_MAX = 3;
    float Pos_x;
    float ObjSize_x;
    float FactPos_x;
    float FactPos_y;
    float Contact_Enemy;
    int NoDamageTime = 120;
    int No_DamageCount;
    bool Contact_P;


    // Start is called before the first frame update
    void Start()
    {
        Hp = new GameObject[HP_MAX];
        GameObject obj = transform.root.gameObject;
        FactPos_x = obj.transform.position.x;
        FactPos_y = obj.transform.position.y;

        //HPをすべて出す
        ObjSize_x = HPgauge.GetComponent<Renderer>().bounds.size.x;
        for (int i = 0; i < HP_MAX; i++)
        {
            Pos_x = i * (ObjSize_x/1.5f);
            var parent = this.transform;
            Hp[i] = Instantiate(HPgauge, new Vector3(Pos_x+FactPos_x, FactPos_y), Quaternion.identity,parent);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Player script = Player.GetComponent<Player>();
        Contact_Enemy = script.Contact_Enemy;
        Contact_P = script.Contact_P;
        
        //HP減少
        if(Contact_P==true)
        {   //無敵時間
            No_DamageCount++;
            if(No_DamageCount == NoDamageTime)
            {
                for(int j=0;j<HP_MAX;j++)
                {
                    Hp[j].SetActive(false);
                }
                for (int i = HP_MAX-1; i >= 0 + Contact_Enemy; i--)
                {
                    Hp[i].SetActive(true);
                    No_DamageCount = 0;
                    Contact_P = false;
                }
            }
        }
    }
}
