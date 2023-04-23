using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionarioController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;

    public bool FimServico = false;
    private void Update()
    {
        if (FimServico == false)
        {
            if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
            {
                MessageBoxController.SetMessages("Funcionario da Navah", new string[4] { "Oi, tudo bem? Eu trabalho no setor de compras...",
                "Nicole: Oi, tudo bem? Eu sou Nicole, sou a funcion�ria nova." + "Eu estava observando e percebi que o senhor est� um pouco sobrecarregado de servi�o." +
                "Como estou chegando agora e estou come�ando, acho que posso auxiliar voc�, voc� gostaria de ajuda?",
                "Realmente, depois da sa�da de outra funcionaria a minha carga de trabalho quase dobrou, estou com bastante servi�o atrasado." + "Eu agradeceria muito se voc� pudesse me ajudar, o chefe j� chamou minha aten��o algumas vezes, mas n�o consigo cuidar de tudo.",
                "Nicole: Certo, pode deixar comigo, s� me explicar direitinho o que fazer que eu te ajudo."},
                -1, true, true);
                Player.CanMove = false;
            }
        }

        if (FimServico == true)
        {
            if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
            {
                MessageBoxController.SetMessages("Funcionario da Navah", new string[2] { "Muito obrigado mesmo, acho que ningu�m havia feito isso por mim, o pessoal apenas me julgava e n�o me apoiava. Novamente agrade�o, foi de grande ajuda para mim",
                "Nicole: N�o h� de que, sinta-se � vontade para pedir ajuda sempre que precisar. Tenha uma boa noite." + "* Os dois seguem seus caminhos e v�o para suas casas"},
                -1, true, true);
                Player.CanMove = false;
            }
        }

    }
}
