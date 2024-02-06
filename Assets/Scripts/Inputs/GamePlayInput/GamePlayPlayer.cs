using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GamePlayPlayer : MonoBehaviour
{
    [SerializeField]
    protected float movSpeed, jumpSpeed, limitSpeed, repulsiveForce;

    [SerializeField]
    private GameObject ptcPrefab;

    protected Rigidbody rigidbody;

    protected bool canMove = true;

    protected GameObject avatar;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public virtual void IniPlayer(GameObject _avatar)
    {
        avatar = _avatar;
    }

    protected virtual void MovePlayer(Vector2 vector)
    {
        Vector3 dir = new Vector3(vector.x, 0.0f, vector.y);
        if (canMove && MovementAccepted(dir))
            rigidbody.AddForce(dir * movSpeed, ForceMode.Impulse);
    }

    protected virtual void JumpPlayer()
    {
        if(canMove)
            rigidbody.AddForce(jumpSpeed * Vector3.up, ForceMode.Impulse);
    }

    protected virtual bool MovementAccepted(Vector3 dir)
    {
        return rigidbody.velocity.magnitude < limitSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LostZone"))
        {
            CrazyApplesSounds.instance.PlaySound(C_A_SOUNDS.FALLING);
            // Asignar puntos etc...
            PlayerActions.OnPlayerDie(this);
        }
    }

    public void OnDiePlayer()
    {
        Destroy(avatar);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CrazyApplesSounds.instance.PlaySound(C_A_SOUNDS.IMPACT);

            GameObject ptc = Instantiate(ptcPrefab);
            ptc.transform.position = collision.GetContact(0).point;

            Vector3 dir = collision.transform.position - transform.position;
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(-dir * repulsiveForce, ForceMode.Force);
        }
        else if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = false;
        }
    }
}
