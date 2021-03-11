using UnityEngine;
using UnityEngine.UI;

public class FileScript : MonoBehaviour
{
    public Text fileNameText;
    public Image fileImage;
    public int index;

    public void OnClick()
    {
        ImportImg.instance.SelectBackGround(index);
    }
}
