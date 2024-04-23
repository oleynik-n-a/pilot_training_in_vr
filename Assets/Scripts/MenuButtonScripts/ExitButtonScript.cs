using UnityEngine;

namespace MenuButtonScripts
{
    public class ExitButtonScript : MonoBehaviour
    {
        public void OnButtonInteraction()
        {
            Application.Quit();
        }
    }
}
