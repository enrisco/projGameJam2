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
                "Nicole: Oi, tudo bem? Eu sou Nicole, sou a funcionária nova." + "Eu estava observando e percebi que o senhor está um pouco sobrecarregado de serviço." +
                "Como estou chegando agora e estou começando, acho que posso auxiliar você, você gostaria de ajuda?",
                "Realmente, depois da saída de outra funcionaria a minha carga de trabalho quase dobrou, estou com bastante serviço atrasado." + "Eu agradeceria muito se você pudesse me ajudar, o chefe já chamou minha atenção algumas vezes, mas não consigo cuidar de tudo.",
                "Nicole: Certo, pode deixar comigo, só me explicar direitinho o que fazer que eu te ajudo."},
                -1, true, true);
                Player.CanMove = false;
            }
        }

        if (FimServico == true)
        {
            if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
            {
                MessageBoxController.SetMessages("Funcionario da Navah", new string[2] { "Muito obrigado mesmo, acho que ninguém havia feito isso por mim, o pessoal apenas me julgava e não me apoiava. Novamente agradeço, foi de grande ajuda para mim",
                "Nicole: Não há de que, sinta-se à vontade para pedir ajuda sempre que precisar. Tenha uma boa noite." + "* Os dois seguem seus caminhos e vão para suas casas"},
                -1, true, true);
                Player.CanMove = false;
            }
        }

    }
}
