using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

    void follow()
    {
        GameObject player = GameObject.Find("player");
        var playerPos = player.transform.position;
        this.transform.position = new Vector3(playerPos.x, playerPos.y, -10f);
    }
}
