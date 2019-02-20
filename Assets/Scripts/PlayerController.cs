using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

    private int count;
    public Text countText;
    public Text winText;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movemnet = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movemnet * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
        }
    }
}
