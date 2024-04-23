using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuButtonScripts
{
    public class SandboxButtonScript : MonoBehaviour
    {
        public void OnButtonInteraction()
        {
            SceneManager.LoadScene(3);
        }
    }
}
