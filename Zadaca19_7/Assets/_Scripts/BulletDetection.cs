using UnityEngine;

public class BulletDetection : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float speed = 5f;
    Vector3 direction;

    private void Awake()
    {
        direction = transform.rotation.eulerAngles;
        rigidbody.linearVelocity = direction * speed;
        Destroy(gameObject, 5f);
    }
}
