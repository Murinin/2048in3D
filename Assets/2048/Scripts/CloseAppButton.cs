using UnityEngine;

public class CloseAppButton : MonoBehaviour
{
    public void OnButtonClick()
    {
       Application.Quit();
        Debug.Log("Exit");
    }
}
