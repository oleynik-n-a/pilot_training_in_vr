using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuButtonScripts
{
    public class TrainingButtonScript : MonoBehaviour
    {
        public void OnButtonInteraction()
        {
            SceneManager.LoadScene(1);
        }
    }
}
