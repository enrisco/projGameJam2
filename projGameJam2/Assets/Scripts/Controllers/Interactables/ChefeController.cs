using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefeController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;

    public bool terminouServico = false;

    void Update()
    {

        if (terminouServico == false)
        {
            if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
            {
                MessageBoxController.SetMessages("Chefe", new string[9] { "Fada: Bom dia, sou o encanador. Foi o senhor que ligou solicitando meus servi�os?",
                "Bom dia. Sim, fui eu mesmo. Por favor, entre e me siga, vou mostrar onde est� o problema." + "Aqui est� o cano estourado",
                "Fada: Senhor, uma coisa que eu n�o consegui deixar de notar � o qu�o bem arrumada e limpa � sua casa. O senhor mesmo que faz a faxina?",
                "N�o, eu tenho uma empregada que vem duas vezes na semana aqui para fazer a faxina.",
                "Fada: Nossa, essa sua empregada deve ser muito dedicada, porque para a casa se manter limpa durante os dias em que ela n�o vem � porque ela limpa muito bem mesmo." + "N�o � t�o f�cil hoje em dia encontrar pessoas que fa�am um trabalho com tanta dedica��o assim.",
                "Voc� tem raz�o. *Risadinha sem gra�a*" + "E agora que eu estava pensando talvez eu n�o a trate do jeito que ela mere�a.",
                "Fada: Como assim?",
                "Acho que �s vezes acabo sendo grosseiro demais com ela e por isso talvez eu n�o tenha reconhecido o esfor�o dela. Acho que tenho que mudar meu jeito de agir com ela.",
                "Fada: Visto o trabalho dela, acho que seria o certo. E tamb�m, encontrar uma pessoa confi�vel para entrar na nossa casa toda semana, sem ter medo dessa pessoa roubar algo, � muito dif�cil."},
                -1, true, true);
                Player.CanMove = false;

            }
        }

        if (terminouServico == true)
        {
            MessageBoxController.SetMessages("Chefe", new string[6] {"*discando no celular...*" + "Boa tarde dona Marilene. Gostaria de ter uma conversa com voc�.",
            "Marilene: Sobre o que seria?",
            "Acredito que n�o tenha valorizado muito o seu trabalho ultimamente, e acho que venho sendo um tanto injusto com voc�. Pe�o desculpas pela forma como venho me comportando e acho que podemos tornar esse ambiente mais tranquilo para ambos.",
            "Marilene: Agrade�o pela sua preocupa��o. Pe�o desculpas tamb�m caso tenha cometido algum erro ou feito algo que voc� desaprovasse.",
            "Voc� fez muito e deixou a casa impec�vel. Estava pensando e acho que podemos discutir aquele aumento que hav�amos conversado antes.",
            "Marilene: Nossa, eu agrade�o muito, o senhor n�o sabe o quanto eu estava precisando desse reconhecimento, muito obrigado mesmo!" + "Desliga o telefone..."},
                -1, true, true);
            Player.CanMove = false;
        }
    }
}
