using System;
using System.Collections.Generic;
using UnityEngine;

public class InGameButtons : EventArgs
{
    private List<GameObject> _buttons;
        
    public InGameButtons(List<GameObject> buttons)
    {
        _buttons = buttons;
    }
}