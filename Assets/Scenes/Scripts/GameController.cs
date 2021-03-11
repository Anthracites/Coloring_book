using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public GameObject ListForm;
    public GameObject FrontImg;
    public GameObject BackImg;
    public Material MatBW;
    public Material MatColor;
    private bool IsBWF = true;
    private bool IsBWB = false;

    public void CloseFilesList()
    {
        ListForm.SetActive(false);
    }

    public void ChangeFrontImg()
    {
        if (IsBWF == false)
        {
            FrontImg.GetComponent<SpriteRenderer>().material = MatBW;
            IsBWF = true;
        }
        else if (IsBWF == true)
        {
            FrontImg.GetComponent<SpriteRenderer>().material = MatColor;
            IsBWF = false;
        }
    }

    public void ChangeBackImg()
    {
        if (IsBWB == false)
        {
            BackImg.GetComponent<SpriteRenderer>().material = MatBW;
            IsBWB = true;
        }
        else if (IsBWB == true)
        {
            BackImg.GetComponent<SpriteRenderer>().material = MatColor;
            IsBWB = false;
        }
    }
}
