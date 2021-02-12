using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public float Speed;
    public bool rainbow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer rend = this.gameObject.GetComponent<Renderer>();
        changeC();
        if (rainbow == true)
        {
            rend.material.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * (Speed / 3), 1), 1, 1)));
        }
        else if (rainbow == false)
        {
            rend.material.color = Color.white;
        }
    }

    void changeC()
    {
        if (Input.GetButtonUp("Fire3")) 
        {
            if (rainbow == false)
            {
                rainbow = true;
            }
            else if (rainbow == true)
            {
                rainbow = false;
            }
        }
    }
}
