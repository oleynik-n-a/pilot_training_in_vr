using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MenuButton : MonoBehaviour
{
    [SerializeField] protected GameObject menuScene;
    [SerializeField] protected GameObject gameScene;
    
    protected void OnStart()
    {
        menuScene.SetActive(false);
        gameScene.SetActive(true);
    }
    
    public void OnEventExitInteraction()
    {
        menuScene.SetActive(true);
        gameScene.SetActive(false);
    }
}
