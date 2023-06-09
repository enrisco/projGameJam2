using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CropTextures : MonoBehaviour
{
    //tipos de corte de imagem usando grids
    public enum Options
    {
        Grid2X2 = 2,
        Grid3X3 = 3,
        Grid4X4 = 4,
        Grid5X5 = 5,
        Grid6X6 = 6,
        Grid7X7 = 7,
        Grid8X8 = 8,
        Grid9X9 = 9,
    };

    public Options GridType;
    public Texture2D sourceTexture;
    public GameObject piecePrefab, gridPrefab;
    public Image img;

    private int amountPieces;
    private List<Vector2> positions = new List<Vector2>();
    private List<Vector2> sortedPositions = new List<Vector2>();
    private Vector2 resolutionPieces, position, distancePieces;

    private void Start()
    {
        StartComponents();
        CreatePositions();
        CreadPiece();
    }

    //Iniciar valores
    void StartComponents()
    {
        amountPieces = (int)GridType;
        resolutionPieces = new Vector2(sourceTexture.width / amountPieces, sourceTexture.height / amountPieces);
        GameManager.currentScore = 0;
        img.sprite = Sprite.Create(sourceTexture, new Rect(0, 0, sourceTexture.width, sourceTexture.height), new Vector2(0.5f, 0.5f));
        GameManager.scoreTotal = amountPieces * amountPieces;
    }

    //Criar as poss�veis posi��es para que as pe�as possam ser instanciadas
    void CreatePositions()
    {
        distancePieces = new Vector2(resolutionPieces.x / 100.0f, resolutionPieces.y / 100.0f);
        for (int x = 0; x < amountPieces; x++)
        {
            for (int y = 0; y < amountPieces; y++)
            {
                positions.Add(new Vector2(x * distancePieces.x, y * distancePieces.y));
            }
        }
    }

    //Sorteando aleatoriamente sempre uma nova posi��o para a pe�a que est� sendo instanciada
    Vector2 RamdomPosition()
    {
        var sorted = false;
        var pos = Vector2.zero;
        while (!sorted)
        {
            pos = positions[Random.Range(0, positions.Count)];
            sorted = !sortedPositions.Contains(pos);
            if (sorted)
            {
                sortedPositions.Add(pos);
            }
        }
        return pos;
    }

    //Instanciar as pe�as na cena que ir�o representar as partes da textura recortada
    void CreadPiece()
    {
        var start = amountPieces - 1;
        for (int i = start; i >= 0; i--)
        {
            for (int j = 0; j < amountPieces; j++)
            {
                var texture = CropTexture(j, i);
                position = RamdomPosition();
                var quad = Instantiate(piecePrefab, position, Quaternion.identity) as GameObject;
                quad.GetComponent<SpriteRenderer>().sprite =
                    Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                quad.GetComponent<BoxCollider2D>().size = new Vector2(distancePieces.x, distancePieces.y);
                quad.GetComponent<PieceScript>().startPosition = position;
                CreateGrid(j, i, quad);
            }
        }
    }

    //Metodo para cortar a imagem em peda�os
    Texture2D CropTexture(int row, int line)
    {
        var resolutionX = Mathf.RoundToInt(resolutionPieces.x);
        var resolutionY = Mathf.RoundToInt(resolutionPieces.y);
        Color[] pixels = sourceTexture.GetPixels(row * resolutionX, line * resolutionY, resolutionX, resolutionY);

        Texture2D tex = new Texture2D(resolutionX, resolutionY);
        tex.SetPixels(pixels);
        tex.Apply();
        return tex;
    }

    //Cria��o de um grid que vai estar integrado as pe�as
    void CreateGrid(int j, int i, GameObject quad) 
    {
        var grid = Instantiate(gridPrefab, new Vector2((j * distancePieces.x) - 10, i * distancePieces.y), Quaternion.identity) as GameObject;
        var newScale = new Vector2(resolutionPieces.x / 150f, resolutionPieces.y / 150f);
        grid.transform.localScale = new Vector3(newScale.x, newScale.y, 0);
        quad.GetComponent<PieceScript>().endPosition = grid.transform.position;
    }
}
