using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [SerializeField] Transform gunBarrel;
    [SerializeField] GameObject bullet;
    [SerializeField] TMP_Text playerHealth;
    [SerializeField] TMP_Text highscoreText;

    private const string HIGHSCORE_KEY = "HIGHSCORE";

    public float health;
    public bool isAlive;
    public int highscore;

    private void Awake()
    {
        Instance = this;
        isAlive = true;
        health = 10;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot();
        }

        if(health <= 0)
        {
            isAlive = false;
            health = 0;
            SceneManager.LoadScene(0);
            PlayerPrefs.SetInt(HIGHSCORE_KEY, highscore);
        }
        playerHealth.text = $"Health: {health}";
        highscoreText.text = $"Highscore: {highscore}";
    }

    private void Shoot()
    {
        Instantiate(bullet, gunBarrel.position, gunBarrel.rotation, null);
    }

}
