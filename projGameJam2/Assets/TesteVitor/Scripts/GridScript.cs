using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<BoxCollider2D>().OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            Check();
    }

    void Check()
    {
        if (Input.GetMouseButton(0) && GameManager.currentPiece != null)
        {
            if (GameManager.currentPiece.GetComponent<PieceScript>().endPosition == transform.position)
            {
                GameManager.currentPiece.transform.position = transform.position;
                GameManager.currentPiece.GetComponent<SpriteRenderer>().sortingOrder = 0;
                Destroy(GameManager.currentPiece.GetComponent<PieceScript>());
                GameManager.currentPiece = null;
                GameManager.currentScore++;
                Destroy(gameObject);
            }

            else
            {
                GameManager.currentPiece.GetComponent<PieceScript>().cancelPiece = true;
            }
        }
    }
}
