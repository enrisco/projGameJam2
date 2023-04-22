using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] MessageBoxController MessageBoxController;

    MovementManager MovementManager;
    // Start is called before the first frame update
    void Start()
    {
        MovementManager = new MovementManager
        (
            transform,
            null,
            Vector3.zero,
            Vector3.zero,
            speed
        );

        StartCoroutine(StartMessage());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        MovementManager.PlayerMove
        (
            new Vector3
            (
                 Input.GetAxis("Horizontal"),
                 Input.GetAxis("Vertical"),
                 0
            )
        ); 
    }

    IEnumerator StartMessage()
    {
        MessageBoxController.SetMessages("Jogador", new string[3]
        {
            "eu sou a mensagem de número 1",
            "eu sou a mensagem de número 2",
            "eu sou a mensagem de número 3"
        }, 2, true, false);

        yield return MessageBoxController.WaitToChoiceNotNull();

        if (MessageBoxController.LastChoice.Valid)
            MessageBoxController.SetMessages
            (
                "Jogador",
                new string[1] { "O usuário escolheu sim" },
                -1,
                false,
                true
            );
        else
            MessageBoxController.SetMessages
            (
                "Jogador",
                new string[1] { "O usuário escolheu não" },
                -1,
                false,
                true
            );
    }
}
