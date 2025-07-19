using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float currentHealth;
    [SerializeField] float maxHealth = 2f;
    [SerializeField] float damage;
    [SerializeField] float speed;
    [SerializeField] Image image;
    [SerializeField] Transform targetTransform;
    private void Awake()
    {
        currentHealth = maxHealth;
        targetTransform = Player.Instance.transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, speed * Time.deltaTime);
        image.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
        {
            Player.Instance.highscore++;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.health -= damage;
            Destroy(gameObject);
        }
        if (collision.gameObject.TryGetComponent<BulletDetection>(out BulletDetection bulletDetection))
        {
            currentHealth--;
        }
    }
}
