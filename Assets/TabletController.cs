using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TabletController : MonoBehaviour
{
    [SerializeField] private GameObject tablet;

    public void Begin(string text)
    {
        tablet.SetActive(true);
        tablet.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(text);
    }

    public void End()
    {
        tablet.SetActive(false);
    }
}
