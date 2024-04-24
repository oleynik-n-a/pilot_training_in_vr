using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace TrainingScripts
{
    public class Training : MonoBehaviour
    {
        [SerializeField] private Material green;
        [SerializeField] private Material orange;
        [SerializeField] private Material red;
        [SerializeField] private GameObject tablet;
    
        private void Start()
        {
            var panels = gameObject.transform.GetChild(gameObject.transform.childCount - 1);
            var buttonsList = new List<GameObject>();
            var buttons = new Queue<GameObject>();
            var random = new System.Random();
            
            for (int i = 0; i < panels.childCount; ++i)
            {
                for (int j = 0; j < panels.GetChild(i).childCount; ++j)
                {
                    var obj = panels.GetChild(i).GetChild(j);
                    obj.name = obj.name.Substring(obj.name.IndexOf('.') + 2);
                    buttonsList.Add(obj.gameObject);
                }
            }

            int buttonListCount = buttonsList.Count;
            for (int i = 0; i < buttonListCount; ++i)
            {
                int current = random.Next(buttonsList.Count);
                buttons.Enqueue(buttonsList[current]);
                buttonsList.RemoveAt(current);
            }
            
            tablet.GetComponent<TrainingTabletController>().InitializeInfo(buttons.Peek().name);
            
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
                        tablet.GetComponent<TrainingTabletController>().IncreaseTotal();
                        if (buttons.Peek() == obj.gameObject)
                        {
                            indicator.GetComponent<MeshRenderer>().material = green;
                        }
                        else
                        {
                            indicator.GetComponent<MeshRenderer>().material = red;
                            buttons.Peek().transform.GetChild(buttons.Peek().transform.childCount - 1)
                                .GetComponent<MeshRenderer>().material = green;
                            tablet.GetComponent<TrainingTabletController>().IncreaseMistakes();
                        }
                        tablet.GetComponent<TrainingTabletController>().ShowInfo(obj.name);
                    });
                
                    xrSimpleInteractable.hoverExited.AddListener(delegate
                    {
                        if (buttons.Peek() != obj.gameObject)
                        {
                            buttons.Peek().transform.GetChild(buttons.Peek().transform.childCount - 1)
                                .GetComponent<MeshRenderer>().material = orange;
                        }
                        buttons.Dequeue();
                        if (buttons.Count == 0)
                        {
                            EndTraining();
                            return;
                        }
                        indicator.GetComponent<MeshRenderer>().material = orange;
                        tablet.GetComponent<TrainingTabletController>().HideInfo(buttons.Peek().name);
                    });
                }
            }
        }

        private void EndTraining()
        {
            var panels = gameObject.transform.GetChild(gameObject.transform.childCount - 1);
            for (int i = 0; i < 1; ++i)
            {
                var panel = panels.GetChild(i);
                for (int j = 0; j < panel.childCount; ++j)
                {
                    panel.GetChild(j).GetChild(panel.GetChild(j).childCount - 1).gameObject.SetActive(false);
                }
            }
        }
    }
}
