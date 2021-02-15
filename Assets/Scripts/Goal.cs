using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject scorePart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyController ball = other.GetComponent<EnemyController>();
        if (ball.isBall == true)
        {
            Score();
        }
    }

    void Score()
    {
        GameObject ball = GameObject.Find("Ball");
        Transform ballPosi = ball.transform;
        Instantiate(scorePart, ballPosi.position, ballPosi.rotation);
    }
}
