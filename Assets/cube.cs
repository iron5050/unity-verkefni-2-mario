using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody rb;
    public bool cubeIsOnTheGround = true;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    //kóði til að láta spilarann hreyfa sig
    void Update() {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 15f, 0f, 0f);

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float Vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, Vertical);

        //kóði til að segja hversu sterkt spilarinn meigi hoppa
        if (Input.GetButtonDown("Jump") && cubeIsOnTheGround) {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            cubeIsOnTheGround = false;
        }
    }
    //kóði til að tékka hvort spilarinn meigi hoppa eftir að hafa snert platform eða gólfið
    private void OnCollisionEnter(Collision collision) { 
        if(collision.gameObject.name == "Floor")

        {
            cubeIsOnTheGround = true;
        }
        else if (collision.gameObject.name == "platform")
        {
            cubeIsOnTheGround = true;
        }
        else if (collision.gameObject.name == "platform (1)")
        {
            cubeIsOnTheGround = true;
        }
        else if (collision.gameObject.name == "platform (2)")
        {
            cubeIsOnTheGround = true;
        }
        else if (collision.gameObject.name == "platform (3)")
        {
            cubeIsOnTheGround = true;
        }
    }
    
}
