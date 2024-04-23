using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
