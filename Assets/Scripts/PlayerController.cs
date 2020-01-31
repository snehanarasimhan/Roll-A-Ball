using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float velocity;
    public Text counter;

    private Rigidbody rigibody;
    private int count;
   
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
        count = 0;
        counter.text = "Count of user: " + count.ToString();
    }


    void fixed_update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0.0f, vertical);

        rigibody.AddForce(move * velocity);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            counter.text = "Count of user: " + count.ToString(); 
        }
    }
}
