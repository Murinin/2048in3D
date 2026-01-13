using UnityEngine;
using UnityEngine.SceneManagement;

public class RetartButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
