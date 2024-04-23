using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TabletController : MonoBehaviour
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
