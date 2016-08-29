using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour
{
    public float moveSpeed = 1;
    public float jumpHeight = 1;
    private bool isFalling = false;
    public Animator anim;
    public Rigidbody rb;
    private float vel;
    private bool mouseclicked;

    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //this doesn't change the speed var
        //this needs to be addforce horizontal
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
        }
        if (Input.GetMouseButtonDown(0))
        {
            //play spell animation
            mouseclicked = true;
            anim.SetTrigger("Firing");
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    //play spell animation
        //    mouseclicked = false;
        //    anim.SetTrigger("Firing");
        //}
        mouseclicked = false;
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
        //
        if (Input.GetButton("Jump") && isFalling == false)
        {
            //this does
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
            isFalling = true;
        }
        //float vel = gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        float speed = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", speed);
        //print(speed);
    }

    void OnCollisionStay()
    {
        isFalling = false;
    }
}