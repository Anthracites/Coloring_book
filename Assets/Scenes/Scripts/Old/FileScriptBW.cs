using UnityEngine;
using UnityEngine.UI;

public class FileScriptBW : MonoBehaviour
{
    public Text fileNameText;
    public Image fileImage;
    public int index;

    public void OnClick()
    {
        ImportImg.instance.SelectBackGroundBW(index);
    }
}
