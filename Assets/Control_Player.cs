using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Player : MonoBehaviour
{
    public float velocity;

    private Rigidbody rigibody;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
        counter = 0;
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
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            counter = counter + 1;
        }
    }
}