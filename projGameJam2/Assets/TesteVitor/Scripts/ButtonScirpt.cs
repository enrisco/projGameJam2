using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScirpt : MonoBehaviour
{
    public Image img;
    private bool isEnable = false;

    public void ClickVewImage()
    {
        isEnable = !isEnable;
        img.gameObject.SetActive(isEnable);
    }
}

