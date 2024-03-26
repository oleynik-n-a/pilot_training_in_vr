using System.Collections.Generic;
using UnityEngine;

public class Exam : MenuButton
{
    [SerializeField] private GameObject questManager;
    private Queue<GameObject> _buttonsQueue;
    private int _mistakes;

    public void OnStartExam()
    {
        OnStart();
        
        _mistakes = 0;
        _buttonsQueue = new Queue<GameObject>();
        System.Random random = new System.Random();
        List<GameObject> buttons = questManager.GetComponent<QuestManager>().GetButtons();
        
        for (int i = buttons.Count - 1; i >= 1; --i)
        {
            int j = random.Next(i + 1);
            (buttons[j], buttons[i]) = (buttons[i], buttons[j]);
        }
        foreach (GameObject button in buttons)
        {
            _buttonsQueue.Enqueue(button);
        }
    }

    public void OnButtonInteraction()
    {
        if (gameObject == _buttonsQueue.Peek())
        {
            _buttonsQueue.Dequeue();
            if (_buttonsQueue.Count == 0)
            {
                menuScene.SetActive(true);
                gameScene.SetActive(false);
            }
        }
        else
        {
            ++_mistakes;
        }
    }
}
