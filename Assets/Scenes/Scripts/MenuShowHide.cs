using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuShowHide : MonoBehaviour
{
    public GameObject SettingsMenu, BrushSpawner, BrushForDestroy;


    public void StartGameButton()
    {
        SettingsMenu.SetActive(false);
        BrushSpawner.SetActive(true);
    }

    void Update()
    {
        MenuSettingsActive();
    }

    void MenuSettingsActive()
    {

        if (Input.GetKey(KeyCode.M))
        {
            SettingsMenu.SetActive(true);
            BrushSpawner.SetActive(false);
        }
    }
}
