using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class TestController : MonoBehaviour
{
    [SerializeField] PlayerController Player;
    [SerializeField] MessageBoxController MessageBoxController;

    [SerializeField] float Distance;
    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < Distance && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
        {
            MessageBoxController.SetMessages("Nicole", new string[1] { "Esses últimos dias têm sido terríveis. Já não bastasse a minha irmã insuportável, " +
                "agora minha mãe vive estressada com seu trabalho e está descontando na gente o tempo todo. " +
                "Lógico, não é por menos, nossa situação financeira está indo de mal a pior ultimamente. " +
                "Dessa forma terei que arrumar um trabalho o quanto antes…" },
            -1, true, true);
            Player.CanMove = false;
        }

        
    }
}
