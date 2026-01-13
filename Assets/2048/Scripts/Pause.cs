using UnityEngine;
using Unity.VisualScripting;

public class Pause : MonoBehaviour
{
    private bool pauseActive = false;
    [SerializeField] private GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (!pauseActive)
        {
            pauseActive = true;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseActive = false;
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
    }
}
