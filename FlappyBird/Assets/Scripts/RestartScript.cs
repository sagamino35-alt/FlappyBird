using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    InputAction ReloadSceneKey;
    InputAction ExitKey;
    public Button ReloadSceneButton;
    public Button ExitButton;
    private void Start()
    {
        ReloadSceneKey = InputSystem.actions.FindAction("Reload");
        ReloadSceneButton.onClick.AddListener(RestartOnClick);



        ExitKey = InputSystem.actions.FindAction("Exit");
        ExitButton.onClick.AddListener(ExitOnClick);
    }

    private void Update()
    {
        RestartGame();
        ExitGame();
    }

    void RestartGame()
    {
        if (ReloadSceneKey.WasPerformedThisFrame())
        {
            SceneManager.LoadScene(0);
            
        }
        
        
        
    }
    
    void RestartOnClick()
    {
        
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    void ExitGame()
    {
        if(ExitKey.WasPerformedThisFrame())
        {
            Application.Quit();
        }
    }

    void ExitOnClick()
    {
        Application.Quit();
    }
}
