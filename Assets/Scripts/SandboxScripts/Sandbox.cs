using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace SandboxScripts
{
    public class Sandbox : MonoBehaviour
    {
        [SerializeField] private Material green;
        [SerializeField] private Material orange;
        [SerializeField] private GameObject tablet;
    
        private void Start()
        {
            var panels = gameObject.transform.GetChild(gameObject.transform.childCount - 1);
            for (int i = 0; i < panels.childCount; ++i)
            {
                var panel = panels.GetChild(i);
                for (int j = 0; j < panel.childCount; ++j)
                {
                    var obj = panel.GetChild(j);
                    var indicator = obj.GetChild(panel.GetChild(j).childCount - 1);
                    var xrSimpleInteractable = indicator.GetComponent<XRSimpleInteractable>();
                
                    xrSimpleInteractable.hoverEntered.AddListener(delegate
                    {
                        indicator.GetComponent<MeshRenderer>().material = green;
                        tablet.GetComponent<SandboxTabletController>().ShowInfo(obj.name);
                    });
                
                    xrSimpleInteractable.hoverExited.AddListener(delegate
                    {
                        indicator.GetComponent<MeshRenderer>().material = orange;
                        tablet.GetComponent<SandboxTabletController>().HideInfo();
                    });
                }
            }
        }
    }
}