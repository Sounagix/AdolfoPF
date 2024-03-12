using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttachment : MonoBehaviour
{
    private Transform ball;

    [SerializeField]
    private float gapY;

    private Animator animator;

    private Transform pointToSee;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void InitAvatar(Transform _ball,Transform _pointToSee)
    {
        ball = _ball;
        pointToSee = _pointToSee;
        Vector3 pos = ball.position;
        pos.y = ball.position.y + gapY;
        transform.position = pos;
    }


    private void LateUpdate()
    {
        Vector3 pos = ball.position;
        pos.y += 0.75f;
        transform.position = pos;
        transform.LookAt(pointToSee);
    }

    public Animator GetAnimator()
    {
        return animator;
    }
}
