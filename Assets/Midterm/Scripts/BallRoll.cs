using UnityEngine;

public class BallRoll : MonoBehaviour
{
    public float moveSpeed = 0.5f;    

    private Rigidbody rb;
    private float moveX;
    private float moveY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0.0f, moveY);
        rb.AddForce(movement * moveSpeed);
    }
}
