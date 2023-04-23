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
            MessageBoxController.SetMessages("Fazuelly", new string[10] {"Oi amiga! Nossa, você veio aqui do nada?" + "Fico feliz.",
            "Fada: O que me conta de novo Fazuelly",
            "Ah, mais do mesmo.A minha irmã continua me importunando e me deixando pra baixo, só porque ela é mais velha.",
            "Fada: Tem certeza que é só por isso? Às vezes temos que nos colocar no lugar dos outros e olhar um pouco fora de nós mesmos." + "Tenho certeza que algumas coisas poderiam ser diferentes se você começasse a assumir certas responsabilidades que irão fazer bem para você." + "Você aparenta estar insegura quanto a isso, não é?",
            "*Suspirando* É... Eu estou um pouco insegura, sabe? Eu fico vendo como a Nicole é madura e responsável, e eu não me sinto assim.",
            "Fada: Você tem muita gente que te ama e se importa com você, você não precisa se sentir assim. Todos vão te ajudar e você pode encarar suas dificuldades e ajudar aqueles que sempre te ajudaram." + "Está na hora de amadurecer e retribuir esse carinho que sempre lhe foi dado",
            "*Fazuelly começa a chorar*" + "Você tem razão…, não posso continuar assim. Acho que devo tentar melhorar a minha forma de pensar as situações",
            "É isso mesmo, todos querem o seu bem, não precisa fazer muito, apenas ajudar aqueles que estão à sua volta." + "*Fada e Fazuelly se abraçam*",
            "Fada: Vou indo então, passei apenas para uma conversinha rápida. Continuamos nos falando depois. Até a próxima",
            "Tudo bem amiga, até a próxima, obrigado pela conversa."},
            -1, true, true);
            Player.CanMove = false;
        }


    }
}
