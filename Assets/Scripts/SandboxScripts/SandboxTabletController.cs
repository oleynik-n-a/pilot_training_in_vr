using TMPro;
using UnityEngine;

namespace SandboxScripts
{
    public class SandboxTabletController : MonoBehaviour
    {
        public void ShowInfo(string text)
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(text);
        }

        public void HideInfo()
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText("Point on sphere!");
        }
    }
}
