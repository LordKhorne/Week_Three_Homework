using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 8.0f;
    [SerializeField] private Ball ballin;

    private void Start()
    {


    }

    private void Update()
    {

        move();

        if (Input.GetKeyDown(KeyCode.Space))
        {



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
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision
}
