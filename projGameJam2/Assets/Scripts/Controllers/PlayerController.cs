using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool CanMove = true;

    [SerializeField] float speed;

    MovementManager MovementManager;
    Animator Animator;
    SpriteRenderer Renderer;
    Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        MovementManager = new MovementManager
        (
            transform,
            null,
            Vector3.zero,
            Vector3.zero,
            speed,
            Rigidbody2D
        );

        Animator = GetComponent<Animator> ();
        Renderer = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (CanMove)
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

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            if (h != 0)
            {
                if (h > 0) Renderer.flipX = false;
                else Renderer.flipX = true;

                Animator.Play("fadaWalkLeft");
            }
            else if (v > 0) Animator.Play("fadaWalkUp");
            else if (v < 0) Animator.Play("fadaWalkDown");
        }
    }
}
