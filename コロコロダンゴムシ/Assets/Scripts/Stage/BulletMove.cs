using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float Pos_x = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Pos_x, 0.0f, 0.0f);
    }
    void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Enemy" || collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
