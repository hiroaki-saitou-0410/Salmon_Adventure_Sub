using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Sockets;
using System.Security.Cryptography;
using UnityEngine;
using RunGame.Stage;
using System.Net;

namespace RunGame.Stage
{
    public class BFF : MonoBehaviour
    {

        public GameObject[] Tama;
        public GameObject player;
        public GameObject BulletFish;
        public int BulletCount;
        public int BulletF_MAX = 5;
        private float P_pos;
        private float r;
        private float angle;
        bool Increase = false;

        // Start is called before the first frame update
        void Start()
        {
            //       BulletCount = GetComponent<BulletFish>().ID;

            BulletFish script = BulletFish.GetComponent<BulletFish>();
            r = script.radius;
        }

        // Update is called once per frame
        void Update()
        {
            Player P_script = player.GetComponent<Player>();
            Increase = P_script.Contact_;

            if(Increase == true)
            {
                BulletFish count = BulletFish.GetComponent<BulletFish>();
                BulletCount = count.counter;
                //UnityEngine.Debug.Log(BulletCount);
                angle = BulletCount * (360 / BulletF_MAX);
                float Rad = angle * Mathf.Deg2Rad * Time.time;
                if (BulletCount == 0)//１つ目
                {
                    float posx = Mathf.Cos(Rad) * r;
                    float posy = Mathf.Sin(Rad) * r;
                    Vector3 new_pos = player.transform.position;
                    new_pos.x += posx;
                    new_pos.y += posy;

                    // 複製を作る
                    Tama[BulletCount] = Instantiate(BulletFish, new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
                    Tama[BulletCount].transform.parent = transform;

                    BulletFish script = Tama[BulletCount].GetComponent<BulletFish>();
                    script.ID = BulletCount;

                    BulletCount++;
                }

                // このifはアイテムをとった場合をテストするためのコード
                else if (BulletCount == 1 && Input.GetKey(KeyCode.Z))//２つ目
                {
                    float posx = Mathf.Cos(Rad) * r;
                    float posy = Mathf.Sin(Rad) * r;
                    Vector3 new_pos = player.transform.position;
                    new_pos.x += posx;
                    new_pos.y += posy;

                    // 複製を作る
                    Tama[BulletCount] = Instantiate(BulletFish, new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
                    Tama[BulletCount].transform.parent = transform;

                    BulletFish script = Tama[BulletCount].GetComponent<BulletFish>();
                    script.ID = BulletCount;

                    BulletCount++;

                }
                else if (BulletCount == 2 && Input.GetKey(KeyCode.Z))//３つ目
                {
                    float posx = Mathf.Cos(Rad) * r;
                    float posy = Mathf.Sin(Rad) * r;
                    Vector3 new_pos = player.transform.position;
                    new_pos.x += posx;
                    new_pos.y += posy;

                    // 複製を作る
                    Tama[BulletCount] = Instantiate(BulletFish, new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
                    Tama[BulletCount].transform.parent = transform;

                    BulletFish script = Tama[BulletCount].GetComponent<BulletFish>();
                    script.ID = BulletCount;

                    BulletCount++;

                }
                else if (BulletCount == 3 && Input.GetKey(KeyCode.Z))//４つ目
                {
                    float posx = Mathf.Cos(Rad) * r;
                    float posy = Mathf.Sin(Rad) * r;
                    Vector3 new_pos = player.transform.position;
                    new_pos.x += posx;
                    new_pos.y += posy;

                    // 複製を作る
                    Tama[BulletCount] = Instantiate(BulletFish, new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
                    Tama[BulletCount].transform.parent = transform;

                    BulletFish script = Tama[BulletCount].GetComponent<BulletFish>();
                    script.ID = BulletCount;

                    BulletCount++;
                }
                else if (BulletCount == 4 && Input.GetKey(KeyCode.Z))//５つ目
                {
                    float posx = Mathf.Cos(Rad) * r;
                    float posy = Mathf.Sin(Rad) * r;
                    Vector3 new_pos = player.transform.position;
                    new_pos.x += posx;
                    new_pos.y += posy;

                    // 複製を作る
                    Tama[BulletCount] = Instantiate(BulletFish, new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
                    Tama[BulletCount].transform.parent = transform;

                    BulletFish script = Tama[BulletCount].GetComponent<BulletFish>();
                    script.ID = BulletCount;

                    BulletCount++;
                }
                P_script.Contact_ = false;
            }

            //中地先生のコード
            //if (BulletCount < BulletF_MAX)
            //{
            //    float posx = Mathf.Cos(Rad) * r;
            //    float posy = Mathf.Sin(Rad) * r;
            //    new_pos = player.transform.position;
            //    new_pos.x += posx;
            //    new_pos.y += posy;
            //    GameObject Bullet_Fish = Instantiate(Tama[i], new Vector3(new_pos.x, new_pos.y), Quaternion.identity);
            //    BulletCount++;
            //}
        }
    }
}