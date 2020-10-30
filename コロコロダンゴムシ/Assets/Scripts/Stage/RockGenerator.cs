using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    GameObject rockgenerator = null;
    //Enemy script = null;
    float enemyTimer;

    //Enemy script;

    public GameObject RockPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        //        rockgenerator = GameObject.Find("岩(Clone)");
        //script = rockgenerator.GetComponent<Enemy>();
        enemyTimer = Enemy.timer;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.tag == "Bullet")
        {
            float timer = enemyTimer;
            Invoke("DelayMethod", timer);
        }
    }
    void DelayMethod()
    {
        Vector2 rock_pos = transform.position;
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                rock_pos.y += 0.5f;
                Instantiate(RockPrefab,
                            rock_pos,
                            Quaternion.identity);
            }
            else if (i == 1)
            {
                rock_pos.x += 0.7f;
                rock_pos.y += 0.5f;
                Instantiate(RockPrefab,
                            rock_pos,
                            Quaternion.identity);
            }
            else if (i == 2)
            {
                rock_pos.x -= 1.4f;
                Instantiate(RockPrefab,
                            rock_pos,
                            Quaternion.identity);
            }
        }
    }
}
