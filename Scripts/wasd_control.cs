using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed=5f;
    public float jump=5f;
    Rigidbody rb;
    bool isGrounded;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            rb.AddForce(Vector3.up*jump,ForceMode.Impulse);
            isGrounded=false;
        }
    }
    void FixedUpdate()
    {
        float x=Input.GetAxis("Horizontal");
        float z=Input.GetAxis("Vertical");
        Vector3 move=transform.right*x+transform.forward*z;
        rb.MovePosition(rb.position+move*speed*Time.fixedDeltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded=true;
        }
    }
}
