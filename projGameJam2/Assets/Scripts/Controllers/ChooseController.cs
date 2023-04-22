using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ChooseController : MonoBehaviour
{
    [SerializeField] GameObject Selector;

    [SerializeField] Vector2 YesPosition;
    [SerializeField] Vector2 NoPosition;

    public Choice LastChoice = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) Selector.GetComponent<RectTransform>().anchoredPosition = YesPosition;
        else if (Input.GetKeyDown(KeyCode.DownArrow)) Selector.GetComponent<RectTransform>().anchoredPosition = NoPosition;
    }

    public IEnumerator WaitForChoose()
    {
        bool userClicked = false;
        while (!userClicked)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                userClicked = true;
                if (Selector.GetComponent<RectTransform>().anchoredPosition == YesPosition)
                    LastChoice = new Choice() { Valid = true };
                else LastChoice = new Choice() { Valid = false };
            }
            yield return null;
        }
    }

}
