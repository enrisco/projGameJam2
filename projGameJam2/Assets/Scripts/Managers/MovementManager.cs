using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class MovementManager
{

    Transform Transform;
    RectTransform RectTransform;
    Rigidbody2D Rigidbody2D;
    Vector3 TargetPos;
    Vector3 InitialPos;

    public float Speed;
    public bool IsParallax;

    public MovementManager(Transform transform, RectTransform rectTransform, Vector3 targetPos, Vector3 initialPos, float speed, Rigidbody2D rigidbody2D)
    { 
        Transform = transform;
        RectTransform = rectTransform;
        TargetPos = targetPos; 
        InitialPos = initialPos;
        Speed = speed;
        Rigidbody2D = rigidbody2D;
    }

    public void PlayerMove(Vector3 pos)
    {
        Vector3 position = Transform.position + pos * Speed * Time.deltaTime;

        Rigidbody2D.MovePosition(position);
    }

    public void Move(bool isRect)
    {
        if (isRect) RectTransform.anchoredPosition = Vector2.MoveTowards(RectTransform.anchoredPosition, TargetPos, Speed * Time.deltaTime);
        else Transform.position = Vector2.MoveTowards(Transform.position, TargetPos, Speed * Time.deltaTime);
    }

    public void ChangeFinalPosition(Vector2 finalPos)
    {
        TargetPos = finalPos;
    }

    public void ChangeSpeed(float speed)
    {
        Speed = speed;
    }

    public bool CheckIfItIsInTargetPosition(bool isRect)
    {
        if (isRect) return RectTransform.anchoredPosition == (Vector2)TargetPos;
        else return Transform.position == TargetPos;
    }
}
