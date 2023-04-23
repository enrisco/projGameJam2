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
            MessageBoxController.SetMessages("Marilene", new string[3] { "*suspiro* Esses dias têm sido mais estressantes que o normal. Meu chefe nunca está contente e aponta defeitos no meu trabalho o dia inteiro. Tudo isso e eu ainda ganho pouco. Vou ter que fazer mais horas de serviço e isso irá me desgastar totalmente.",
                "Nicole: Eu entendo mãe, porém você tem agido de uma maneira não muito bacana conosco.", "Depois de tudo que eu passo na semana ainda tenho que ouvir isso, vocês nunca estão contentes, eu fico fora trabalhando a semana inteira por causa de vocês..." },
            -1, true, true);
            Player.CanMove = false;

        }
    }
}
