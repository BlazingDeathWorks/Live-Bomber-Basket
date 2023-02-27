using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private int _scoreAdditionFactor = 10;
    private int _score;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1;
    }

    public void IncreaseScore()
    {
        _score += _scoreAdditionFactor;
        _scoreText.text = $"Score: {_score}";
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        _restartButton.gameObject.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
