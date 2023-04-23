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
            "Bom, eu estou aqui hoje para falar algumas palavras para voc�s sobre empatia. Para come�ar, ter empatia � compreender os sentimentos do outro." +
            "Quando temos empatia por algu�m, nos colocamos no lugar daquela pessoa e nos perguntamos como nos sentimos naquela determinada situa��o. Depois disso, refletimos como nossas atitudes est�o interferindo aquela pessoa e a� identificamos se devemos mudar ou agir de outra maneira." +
            "Devemos sempre buscar resolver as coisas da melhor maneira poss�vel sem ferir nenhum dos lados, e � a� que se aplica a empatia, para poder compreender o pr�ximo." +
            "Pe�o aos alunos que pensem com carinho nisso, pois sempre temos como melhorar e �s vezes podemos ter um impacto positivo no nosso ambiente de trabalho, na escola e em casa." + 
            "Me despe�o e agrade�o a Escola por me deixar palestrar aqui hoje e tamb�m agrade�o a todos os alunos que aqui est�o.",
            "*Turma fica em sil�ncio...*" + "*Parece que a palestra mexeu com eles"},
            -1, true, true);
            Player.CanMove = false;
        }


    }
}
