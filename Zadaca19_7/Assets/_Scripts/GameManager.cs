using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform[] spawnPoints;
    void Start()
    {
        if(Player.Instance.isAlive) 
        {
            Debug.Log("OKAY");
            InvokeRepeating(nameof(Spawn), 2f, 2f);
        }
    }

    void Spawn()
    {
        Debug.Log("Spawns");
        int random = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[random].transform.position, Quaternion.identity);
    }
}
