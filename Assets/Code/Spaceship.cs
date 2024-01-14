using UnityEngine;

public class Spaceship : MonoBehaviour
{
    private float speed = 6.0f;
    private float speedX, speedY;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal")*speed;
        speedY = Input.GetAxisRaw("Vertical")*speed;

        rigidbody.velocity = new Vector2(speedX, speedY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = 0.0f;

            this.gameObject.SetActive(false);

            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
