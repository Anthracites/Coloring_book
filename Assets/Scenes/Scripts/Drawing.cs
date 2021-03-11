using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public GameObject BrushPreffab, ParentBrush;
    private GameObject inst_obj;
    private Vector3 mousePos;


    void Update()

    {
        {
            DrawColor();
        }
    }

        void DrawColor()
        {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if ((mousePos.x > -15) & (mousePos.x < 15) & (mousePos.y > -10) & (mousePos.y < 10) & (mousePos != Input.mousePosition))
            {
            Vector3 SpawnPosition = new Vector3(mousePos.x, mousePos.y, 0);
            Quaternion spawnRotation = Quaternion.identity;
            /*var go*/
            inst_obj = Instantiate(BrushPreffab, SpawnPosition, spawnRotation) as GameObject;
            inst_obj.transform.parent = ParentBrush.transform;

        }
        }

    
}