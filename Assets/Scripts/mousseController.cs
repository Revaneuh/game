using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousseController : MonoBehaviour
{
    /* // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1f));
        this.transform.position = new Vector3(newPos.x ,newPos.y, -1f);
    } */

    public float RotateSpeed = 2.5f;
    public float Radius = 0.1f;

    private Vector2 _centre;
    public float _angle;

    private void Start()
    {
        GameObject player = GameObject.Find("player");
        _centre = player.transform.position;
        _angle = -5.897987f;
    }

    private void Update()
    {
        GameObject player = GameObject.Find("player");
        _angle += Input.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        _centre = player.transform.position;
        transform.position = _centre + offset;
    }
}
