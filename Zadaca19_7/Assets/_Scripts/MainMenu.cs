using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private const string HIGHSCORE_KEY = "HIGHSCORE";
    [SerializeField] TMP_Text highscoreText;

    private void Awake()
    {
        highscoreText.text =$"HIGHSCORE: {PlayerPrefs.GetInt(HIGHSCORE_KEY).ToString()}" ;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
