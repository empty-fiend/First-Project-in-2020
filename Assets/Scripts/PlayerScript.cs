using System;
using UnityEngine;
    

public class PlayerScript : MonoBehaviour, ICharacter
{
    public float speed = 3f;
    public float jumpForce = 1.5f;
    public bool isDead;
    public float distance = 1f;

    public LayerMask ground;
    public GameObject gameOverScreen;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       Walk();
       Jump();
    }

    public bool Grounded()
    {
        return Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance, ground);
    }

    public void Walk()
    {
        var move = Input.GetAxis("Horizontal");
        if (Grounded())
        {
            _rb.velocity = new Vector2(move * speed, _rb.velocity.y);
        }
    }

    public void Jump()
    {
        var jump = Input.GetButton("Jump");
        if (Grounded() && jump)
        {
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void DealDamage()
    {
        throw new NotImplementedException();
    }

    public void GetDamage()
    {
        throw new NotImplementedException();
    }

    public void Die()
    {
        isDead = true;
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
}
