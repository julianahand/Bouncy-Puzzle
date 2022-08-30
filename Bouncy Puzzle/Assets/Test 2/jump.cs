using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
        
    {
        rb = this.GetComponent<Rigidbody> ();
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true && Input.GetMouseButtonUp (0)){
            rb.AddForce (new Vector3 (0f, 500f, 0f));
        }

    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name == "Ground"){
            isGrounded = true;
        }

    }
    void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.name == "Ground"){
            isGrounded = false;
        }

    }
}
