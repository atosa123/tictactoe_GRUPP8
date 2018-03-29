using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadMainScene()
    {
	SceneManager.LoadScene("Main");

    }
    public void ExitGame()
    {
	Application.Quit();
	Debug.Log("Om programmet hadde byggds skulle det stängas ner nu");
    }
}
