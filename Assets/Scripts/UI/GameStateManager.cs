using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public void GameLost(Component sender, object obj)
    {
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    }
}
