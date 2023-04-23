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
    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < 1 && Input.GetKeyDown(KeyCode.Z) && Player.CanMove)
        {
            MessageBoxController.SetMessages("Nicole", new string[1] { "Oi, eu sou a Nicole e sou muito triste" }, -1, true, true);
            Player.CanMove = false;
        }
    }
}
