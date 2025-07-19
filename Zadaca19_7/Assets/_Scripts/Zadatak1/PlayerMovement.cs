using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float speed = 100f;


    public bool hasKey;

    void FixedUpdate()
    {
        rigidbody.linearVelocity = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            rigidbody.linearVelocity = Vector3.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            rigidbody.linearVelocity = Vector3.back * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.linearVelocity = Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            rigidbody.linearVelocity = Vector3.right * speed * Time.deltaTime;
        }
    }
}
