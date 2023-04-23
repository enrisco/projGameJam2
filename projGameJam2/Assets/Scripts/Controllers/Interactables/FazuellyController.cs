using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FazuellyController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;
    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
        {
            MessageBoxController.SetMessages("Fazuelly", new string[10] {"Oi amiga! Nossa, voc� veio aqui do nada?" + "Fico feliz.",
            "Fada: O que me conta de novo Fazuelly",
            "Ah, mais do mesmo.A minha irm� continua me importunando e me deixando pra baixo, s� porque ela � mais velha.",
            "Fada: Tem certeza que � s� por isso? �s vezes temos que nos colocar no lugar dos outros e olhar um pouco fora de n�s mesmos." + "Tenho certeza que algumas coisas poderiam ser diferentes se voc� come�asse a assumir certas responsabilidades que ir�o fazer bem para voc�." + "Voc� aparenta estar insegura quanto a isso, n�o �?",
            "*Suspirando* �... Eu estou um pouco insegura, sabe? Eu fico vendo como a Nicole � madura e respons�vel, e eu n�o me sinto assim.",
            "Fada: Voc� tem muita gente que te ama e se importa com voc�, voc� n�o precisa se sentir assim. Todos v�o te ajudar e voc� pode encarar suas dificuldades e ajudar aqueles que sempre te ajudaram." + "Est� na hora de amadurecer e retribuir esse carinho que sempre lhe foi dado",
            "*Fazuelly come�a a chorar*" + "Voc� tem raz�o�, n�o posso continuar assim. Acho que devo tentar melhorar a minha forma de pensar as situa��es",
            "� isso mesmo, todos querem o seu bem, n�o precisa fazer muito, apenas ajudar aqueles que est�o � sua volta." + "*Fada e Fazuelly se abra�am*",
            "Fada: Vou indo ent�o, passei apenas para uma conversinha r�pida. Continuamos nos falando depois. At� a pr�xima",
            "Tudo bem amiga, at� a pr�xima, obrigado pela conversa."},
            -1, true, true);
            Player.CanMove = false;
        }


    }
}
