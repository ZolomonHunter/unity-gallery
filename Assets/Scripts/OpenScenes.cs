using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScenes : MonoBehaviour
{
    public string sceneName;

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
