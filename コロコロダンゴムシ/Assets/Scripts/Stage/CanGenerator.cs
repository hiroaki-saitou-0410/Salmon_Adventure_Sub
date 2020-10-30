using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanGenerator : MonoBehaviour
{
    GameObject cangenerator;
    //public GameObject gomi;
    //Enemy E_script = gomi.GetComponent<Enemy>();
    float enemyTimer;

    public GameObject CanPrefab = null;

    // Start is called before the first frame update
    void Start()
    {

        enemyTimer = Enemy.timer;
        //script = cangenerator.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        float timer = enemyTimer;
        if (collision.tag == "Bullet")
        {
            Invoke("DelayMethod", timer);
        }
    }
    void DelayMethod()
    {

        Vector2 can_pos = transform.position;
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Instantiate(CanPrefab,
                            can_pos,
                            Quaternion.identity);
            }
            else if(i == 1)
            {
                can_pos.x += 0.5f;
                can_pos.y += 0.5f;
                Instantiate(CanPrefab,
                            can_pos,
                            Quaternion.identity);
            }
            else if (i == 2)
            {
                can_pos.x -= 1.0f;
                Instantiate(CanPrefab,
                            can_pos,
                            Quaternion.identity);
            }
        }
    }
}
