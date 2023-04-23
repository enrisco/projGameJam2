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
                MessageBoxController.SetMessages("Chefe", new string[9] { "Fada: Bom dia, sou o encanador. Foi o senhor que ligou solicitando meus serviços?",
                "Bom dia. Sim, fui eu mesmo. Por favor, entre e me siga, vou mostrar onde está o problema." + "Aqui está o cano estourado",
                "Fada: Senhor, uma coisa que eu não consegui deixar de notar é o quão bem arrumada e limpa é sua casa. O senhor mesmo que faz a faxina?",
                "Não, eu tenho uma empregada que vem duas vezes na semana aqui para fazer a faxina.",
                "Fada: Nossa, essa sua empregada deve ser muito dedicada, porque para a casa se manter limpa durante os dias em que ela não vem é porque ela limpa muito bem mesmo." + "Não é tão fácil hoje em dia encontrar pessoas que façam um trabalho com tanta dedicação assim.",
                "Você tem razão. *Risadinha sem graça*" + "E agora que eu estava pensando talvez eu não a trate do jeito que ela mereça.",
                "Fada: Como assim?",
                "Acho que às vezes acabo sendo grosseiro demais com ela e por isso talvez eu não tenha reconhecido o esforço dela. Acho que tenho que mudar meu jeito de agir com ela.",
                "Fada: Visto o trabalho dela, acho que seria o certo. E também, encontrar uma pessoa confiável para entrar na nossa casa toda semana, sem ter medo dessa pessoa roubar algo, é muito difícil."},
                -1, true, true);
                Player.CanMove = false;

            }
        }

        if (terminouServico == true)
        {
            MessageBoxController.SetMessages("Chefe", new string[6] {"*discando no celular...*" + "Boa tarde dona Marilene. Gostaria de ter uma conversa com você.",
            "Marilene: Sobre o que seria?",
            "Acredito que não tenha valorizado muito o seu trabalho ultimamente, e acho que venho sendo um tanto injusto com você. Peço desculpas pela forma como venho me comportando e acho que podemos tornar esse ambiente mais tranquilo para ambos.",
            "Marilene: Agradeço pela sua preocupação. Peço desculpas também caso tenha cometido algum erro ou feito algo que você desaprovasse.",
            "Você fez muito e deixou a casa impecável. Estava pensando e acho que podemos discutir aquele aumento que havíamos conversado antes.",
            "Marilene: Nossa, eu agradeço muito, o senhor não sabe o quanto eu estava precisando desse reconhecimento, muito obrigado mesmo!" + "Desliga o telefone..."},
                -1, true, true);
            Player.CanMove = false;
        }
    }
}
