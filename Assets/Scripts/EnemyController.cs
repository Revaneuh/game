using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool isBall = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
        var veloc = rb.velocity;
        rb.velocity = new Vector2(veloc.x * 0.995f, veloc.y * 0.995f);
        if (Mathf.Abs(veloc.x) < 0.05f || Mathf.Abs(veloc.y) < 0.05f)
        {
            //rb.velocity = new Vector2(0f, 0f);
        }
    }
}
