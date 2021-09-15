using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 10.0f;
    private Ball ball = null;

    private void Start()
    {

        ball = GameObject.Find("Ball").GetComponent<Ball>();

    }

    private void Update()
    {

        if (ball == null)
        {

            ball = GameObject.Find("Ball(Clone)").GetComponent<Ball>();

        }

        move();

        if (Input.GetKeyDown(KeyCode.Space) && !ball.getLaunched())
        {

            ball.launch();

        }


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

    //TODO
    // A launched ball will then bounce around, changing its direction upon any collision
}
