using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System.IO;
using System.Linq;
using System;
using System.Windows;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

public class ImportImg : MonoBehaviour
{
    public GameObject fileListPan, fileContent, filePrefab, filePrefabBW, filePrefabOne;
    public GameObject BackGroundImg;
    public GameObject BackGroundImgBW;
    private DirectoryInfo dirInfo = new DirectoryInfo(@"ForUpload");
    private FileInfo[] files;
    private GameObject[] instanceObjs;
    public static ImportImg instance;
    public GameObject BackGroundChoseObject;
    private Sprite[] mySprite;
    private Sprite[] myPreSprite;
    private int w;
    private int h;
    private UInt32 pix;


    private void Awake()
    {
        instance = this;
    }
    public void LoadBackGroundList()
    {
        BackGroundChoseObject.SetActive(true);
        files = new string[] { "*.jpeg", "*.jpg", "*.png" }.SelectMany(ext => dirInfo.GetFiles(ext, SearchOption.AllDirectories)).ToArray();
        instanceObjs = new GameObject[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            WWW www = new WWW("file://" + files[i].FullName);
            var myPreSprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
            FileScript file = Instantiate(filePrefab, fileContent.transform).GetComponent<FileScript>();
            file.fileNameText.text = files[i].Name;
            file.fileImage.sprite = myPreSprite;

            file.index = i;
            instanceObjs[i] = file.gameObject;
        }

    }
    public void SelectBackGround(int index)
    {
        WWW www = new WWW("file://" + files[index].FullName);
        var mySprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
        BackGroundImg.GetComponent<SpriteRenderer>().sprite = mySprite;
        fileListPan.SetActive(false); BackGroundImg.gameObject.SetActive(true);
        foreach (GameObject obj in instanceObjs)
            Destroy(obj);
    }

    public void LoadBackGroundBWList()
    {
        BackGroundChoseObject.SetActive(true);
        files = new string[] { "*.jpeg", "*.jpg", "*.png" }.SelectMany(ext => dirInfo.GetFiles(ext, SearchOption.AllDirectories)).ToArray();
        instanceObjs = new GameObject[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            WWW www = new WWW("file://" + files[i].FullName);
            var myPreSprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
            FileScriptBW file = Instantiate(filePrefabBW, fileContent.transform).GetComponent<FileScriptBW>();
            file.fileNameText.text = files[i].Name;
            file.fileImage.sprite = myPreSprite;

            file.index = i;
            instanceObjs[i] = file.gameObject;
        }
    }

    public void SelectBackGroundBW(int index)
    {
        WWW www = new WWW("file://" + files[index].FullName);
        var mySprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
        BackGroundImgBW.GetComponent<SpriteRenderer>().sprite = mySprite;
        fileListPan.SetActive(false); BackGroundImgBW.gameObject.SetActive(true);
        foreach (GameObject obj in instanceObjs)
            Destroy(obj);
    }


    public void LoadBackGroundOneList()
    {
        BackGroundChoseObject.SetActive(true);
        files = new string[] { "*.jpeg", "*.jpg", "*.png" }.SelectMany(ext => dirInfo.GetFiles(ext, SearchOption.AllDirectories)).ToArray();
        instanceObjs = new GameObject[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            WWW www = new WWW("file://" + files[i].FullName);
            var myPreSprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
            FileScriptOne file = Instantiate(filePrefabOne, fileContent.transform).GetComponent<FileScriptOne>();
            file.fileNameText.text = files[i].Name;
            file.fileImage.sprite = myPreSprite;

            file.index = i;
            instanceObjs[i] = file.gameObject;
        }
    }

    public void SelectBackGroundOne(int index)
    {
        WWW www = new WWW("file://" + files[index].FullName);
        var mySprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f, (www.texture).width, (www.texture).height), new Vector2(0.5f, 0.5f), 100.0f);
        BackGroundImg.GetComponent<SpriteRenderer>().sprite = mySprite;
       BackGroundImgBW.GetComponent<SpriteRenderer>().sprite = mySprite;


        fileListPan.SetActive(false); BackGroundImg.gameObject.SetActive(true);
        foreach (GameObject obj in instanceObjs)
            Destroy(obj);
    }

}

/*for (int h = 0; h < (www.texture).height; h++)
            for (int w = 0; w<(www.texture).width; w++)
                {
                    //UInt32 pixel = (UInt32)System.Drawing.Color.ToArgb((www.texture).GetPixel(h, w));
                    //UInt32 pixel = (UInt32)System.Drawing.Color.ToArgb((www.texture).GetPixel(w, h));
                    //UInt32 pixel = (UInt32)www.texture.GetPixel(w, h).ToArgb();
                    //String pixel = ColorUtility.ToHtmlStringRGBA(www.texture.GetPixel(w, h));
                    UnityEngine.Color pixel = www.texture.GetPixel(h, w);
float pixel_r = (float)(pixel[0] * 0.21);
float pixel_g = (float)(pixel[1] * 0.71);
float pixel_b = (float)(pixel[2] * 0.71);
UnityEngine.Color new_pixel_color = new UnityEngine.Color(pixel_r, pixel_g, pixel_b, 255);
www.texture.SetPixel(h, w, new_pixel_color);

                    //UInt32 pixel_r = UInt32.Parse(pixel.Substring(0, 1));
                    //UInt32 pixel_g = UInt32.Parse(pixel.Substring(2, 3));
                    //UInt32 pixel_b = UInt32.Parse(pixel.Substring(4, 5));
                    //float R = (float)((pixel_r & 0x00FF0000) >> 16);
                    //float G = (float)((pixel_g & 0x0000FF00) >> 8);
                    //float B = (float)(pixel_b & 0x000000FF);
                    //R = G = B = (R + G + B) / 3.0f;
                    //UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    //UnityEngine.Color new_pixel_color = new UnityEngine.Color(((UInt32)R << 16), ((UInt32)G << 8), ((UInt32)B), 255);
                    //(www.texture).SetPixel(h, w, System.Drawing.Color.FromArgb((int)newPixel));
                    //String new_pixel_string = newPixel.ToString();
                    //(www.texture).SetPixel(h, w, new_pixel_color);
                    //output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }*/