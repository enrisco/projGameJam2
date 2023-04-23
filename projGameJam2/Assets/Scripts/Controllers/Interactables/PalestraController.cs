using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalestraController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;
    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
        {
            MessageBoxController.SetMessages("Fada", new string[4] { "Bom dia, turma!",
            "Turma da Nicole: *Tom desanimado* Bom dia...",
            "Bom, eu estou aqui hoje para falar algumas palavras para vocês sobre empatia. Para começar, ter empatia é compreender os sentimentos do outro." +
            "Quando temos empatia por alguém, nos colocamos no lugar daquela pessoa e nos perguntamos como nos sentimos naquela determinada situação. Depois disso, refletimos como nossas atitudes estão interferindo aquela pessoa e aí identificamos se devemos mudar ou agir de outra maneira." +
            "Devemos sempre buscar resolver as coisas da melhor maneira possível sem ferir nenhum dos lados, e é aí que se aplica a empatia, para poder compreender o próximo." +
            "Peço aos alunos que pensem com carinho nisso, pois sempre temos como melhorar e às vezes podemos ter um impacto positivo no nosso ambiente de trabalho, na escola e em casa." + 
            "Me despeço e agradeço a Escola por me deixar palestrar aqui hoje e também agradeço a todos os alunos que aqui estão.",
            "*Turma fica em silêncio...*" + "*Parece que a palestra mexeu com eles"},
            -1, true, true);
            Player.CanMove = false;
        }


    }
}
