using UnityEngine;
using UnityEngine.UI;

public class FileScriptOne : MonoBehaviour
{
    public Text fileNameText;
    public Image fileImage;
    public int index;

    public void OnClick()
    {
        ImportImg.instance.SelectBackGroundOne(index);
    }
}
