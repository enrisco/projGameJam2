using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshPro text;
    public static GameObject currentPiece;
    public static int currentScore, scoreTotal;

    void Update()
    {
        if (currentScore == scoreTotal)
        {
            text.gameObject.SetActive(true);
        }
    }
}
