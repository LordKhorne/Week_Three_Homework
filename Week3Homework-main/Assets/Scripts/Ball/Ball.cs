using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody = null;
    public bool launched = false;
    public float paddleSpeed = 10.0f;
    public float ballSpeed = 20.0f;
    private Vector3 direction = Vector3.zero;

    private void Update()
    {

        if (!launched)
        {

            move();

        }
        else
        {

            var newDelta = direction * Time.deltaTime * ballSpeed;
            rigidBody.MovePosition(transform.position + newDelta);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        direction = Vector2.Reflect(direction, collision.contacts[0].normal);

    }

    void move()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * paddleSpeed * horizontalInput * Time.deltaTime);

        if (transform.position.x < -6.0f)
        {

            transform.position = new Vector3(-6.0f, transform.position.y, 0);

        }

        if (transform.position.x > 6.0f)
        {

            transform.position = new Vector3(6.0f, transform.position.y, 0);

        }



    }

    public bool getLaunched()
    {

        return launched;

    }

    public void launch()
    {

        launched = true;
        direction = new Vector3(transform.position.x, 50, 0);

    }

    public void notLaunch()
    {

        launched = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Piece")
        {

            Destroy(collision.gameObject);
        
        }

    }

    }
