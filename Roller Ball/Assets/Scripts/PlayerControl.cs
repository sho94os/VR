using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 1f;
    Rigidbody rb;

    public bool keyboard;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody >(); 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(keyboard == true){
            
    
            float moveHorizontal = Input.GetAxis ("Horizontal");
            float moveVertical = Input.GetAxis ("Vertical");

            Vector3 movment = new Vector3(moveHorizontal,0f,moveVertical);

            rb.AddForce(movment * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }


}
