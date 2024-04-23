using TMPro;
using UnityEngine;

namespace TrainingScripts
{
    public class TrainingTabletController : MonoBehaviour
    {
        private int _total;
        private int _mistakes;

        private void Start()
        {
            _total = 0;
            _mistakes = 0;
        }

        public void InitializeInfo(string task)
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText("text");
            gameObject.transform.GetChild(1).GetComponent<TextMeshPro>().SetText(task);
            gameObject.transform.GetChild(2).GetComponent<TextMeshPro>().SetText($"total: {_total}");
            gameObject.transform.GetChild(3).GetComponent<TextMeshPro>().SetText($"mistakes: {_mistakes}");
        }
        
        public void ShowInfo(string text)
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(text);
            gameObject.transform.GetChild(2).GetComponent<TextMeshPro>().SetText($"total: {_total}");
            gameObject.transform.GetChild(3).GetComponent<TextMeshPro>().SetText($"mistakes: {_mistakes}");
        }

        public void HideInfo(string task)
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText("");
            gameObject.transform.GetChild(1).GetComponent<TextMeshPro>().SetText(task);
        }

        public void IncreaseTotal()
        {
            ++_total;
        }

        public void IncreaseMistakes()
        {
            ++_mistakes;
        }
    }
}
