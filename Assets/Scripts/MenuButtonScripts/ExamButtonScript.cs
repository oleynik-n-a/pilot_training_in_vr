using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuButtonScripts
{
    public class ExamButtonScript : MonoBehaviour
    {
        public void OnButtonInteraction()
        {
            SceneManager.LoadScene(2);
        }
    }
}
