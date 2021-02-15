using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
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
        /*
        GameObject head = this.gameObject.transform.GetChild(0).gameObject;
        Quaternion rotation = Quaternion.LookRotation(head.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);*/
    }
}
