using UnityEngine;

public class Pit : MonoBehaviour
{
    public GameObject player;

    private Transform _pitTransform;
    private Transform _playerTransform;
    private Collider2D _pitCollider2D;
    private Collider2D _playerCollider2D;
    private PlayerScript _playerScript;

    // Update is called once per frame
    private void Start()
    {
        _playerScript = player.GetComponent<PlayerScript>();
        _playerCollider2D = player.GetComponent<Collider2D>();
        _pitCollider2D = GetComponent<Collider2D>();
        _playerTransform = player.GetComponent<Transform>();
        _pitTransform = GetComponent<Transform>();
    }

    void Update()
    {
        _pitTransform.position = new Vector3(_playerTransform.position.x, _pitTransform.position.y);

            if (Physics2D.IsTouching(_pitCollider2D, _playerCollider2D))
                _playerScript.Die();
    }
}
