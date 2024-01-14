using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private int speedMin = 3;
    private int speedMax = 8;
    private int lifetime = 8;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Destroy(this.gameObject, this.lifetime);
    }

    public void SetMovement(Vector2 direction)
    {
        rigidbody.velocity = direction * Random.Range(this.speedMin, this.speedMax);
    }
}
