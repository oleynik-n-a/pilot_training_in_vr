using TMPro;
using UnityEngine;

namespace ExamScripts
{
    public class ExamTabletController : MonoBehaviour
    {
        private int _total;
        private int _mistakes;

        private void Start()
        {
            _total = 0;
            _mistakes = 0;
        }
        
        public void UpdateInfo(string task)
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(task);
        }

        public void ShowScore()
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(
                $"Score: {_total - _mistakes}/{_total}\n" +
                $"Grade: {((double)(_total - _mistakes) / _total * 10):f0}/10");
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
