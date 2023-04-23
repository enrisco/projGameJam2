using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarileneController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;

    void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
        {
            MessageBoxController.SetMessages("Marilene", new string[3] { "*suspiro* Esses dias t�m sido mais estressantes que o normal. Meu chefe nunca est� contente e aponta defeitos no meu trabalho o dia inteiro. Tudo isso e eu ainda ganho pouco. Vou ter que fazer mais horas de servi�o e isso ir� me desgastar totalmente.",
                "Nicole: Eu entendo m�e, por�m voc� tem agido de uma maneira n�o muito bacana conosco.", "Depois de tudo que eu passo na semana ainda tenho que ouvir isso, voc�s nunca est�o contentes, eu fico fora trabalhando a semana inteira por causa de voc�s..." },
            -1, true, true);
            Player.CanMove = false;

        }
    }
}
