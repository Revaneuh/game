using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float y;
    float x;
    public Rigidbody2D rb;
    public float force;
    public GameObject part;
    public Transform partPoint;
    public float boost;
    public Transform boostp1;
    public Transform boostp2;
    public bool hasBoosted = false;
    public bool delaying = false;
    public float Avelo;
    public float _Avelo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        turnPlayer();
        if (hasBoosted == true && delaying == false)
        {
            StartCoroutine(BoostDelay());
            delaying = true;
        }
        resetVelo();
    }

    void move()
    {
        
        
        if (Input.GetAxisRaw("Vertical") > 0.1f)
        {
            
            Instantiate(part, partPoint.position, partPoint.rotation);
            if (Input.GetButtonDown("Jump") && hasBoosted == false)
            {
                Debug.Log("Boost!");
                rb.AddForce(transform.right * boost);
                Instantiate(part, boostp1.position, boostp1.rotation);
                Instantiate(part, boostp2.position, boostp2.rotation);
                hasBoosted = true;
            }
            else
            {
                    
                rb.AddForce(transform.right * force);

            }
            
            

        }
        else
        {

            var veloc = rb.velocity;
            rb.velocity = new Vector2(veloc.x * 0.96f, veloc.y * 0.96f);
            if (Mathf.Abs(veloc.x) < 0.05f || Mathf.Abs(veloc.y) < 0.05f)
            {
                rb.velocity = new Vector2(0f, 0f);
            }

        }



    }

    void turnPlayer()
    {
        GameObject mousse = GameObject.Find("mousse");
        Quaternion rotation = Quaternion.LookRotation(mousse.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

    }

    IEnumerator BoostDelay()
    {
        yield return new WaitForSeconds(3f);
        hasBoosted = false;
        delaying = false;
    }

    void resetVelo()
    {
        if ((rb.angularVelocity + 0.2f) < _Avelo)
        {
            rb.angularVelocity = 0f;
        }
        else 
        {
            
        }
    }



}
