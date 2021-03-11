using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject SettingsMenu, BrushSpawner, ParentBrushForDestroy;
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);

    public void StartGameButton()
    {
        SettingsMenu.SetActive(false);
        BrushSpawner.SetActive(true);
        int xPos = 0, yPos = 0;
        SetCursorPos(xPos, yPos);
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
            for (int i = ParentBrushForDestroy.transform.childCount; i > 0; --i)
            {
                DestroyImmediate(ParentBrushForDestroy.transform.GetChild(0).gameObject);
            }
        }
    }
}
