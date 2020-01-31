using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScripts : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject player;
    private bool _isPaused;
    private PlayerScript _playerScript;

    private void Start()
    {
        _playerScript = player.GetComponent<PlayerScript>();
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!_playerScript.isDead)
            if (Input.GetButtonDown("Pause"))
                if (_isPaused)
                    Resume();
                else
                    Pause();
    }
    public void Resume()
    {
        pauseScreen.SetActive(false);
        _isPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        _isPaused = true;
        Time.timeScale = 0f;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
