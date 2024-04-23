using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private GameObject panels;
    private List<GameObject> _buttons;
    
    // Start is called before the first frame update
    void Start()
    {
        _buttons = new List<GameObject>();
        for (int i = 0; i < panels.transform.childCount; i++)
        {
            for (int j = 0; j < panels.transform.GetChild(i).childCount; j++)
            {
                _buttons.Add(panels.transform.GetChild(i).GetChild(j).gameObject);
            }
        }
    }

    public List<GameObject> GetButtons()
    {
        return _buttons;
    }

    public static void ShowInfo()
    {
        
    }
    
    //public static void 
}
