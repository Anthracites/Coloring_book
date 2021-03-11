using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPicture : MonoBehaviour
{
    public GameObject BrushForDestroy;

    void OnBecameVisible()
    {
        Destroy(BrushForDestroy);
    }
}
