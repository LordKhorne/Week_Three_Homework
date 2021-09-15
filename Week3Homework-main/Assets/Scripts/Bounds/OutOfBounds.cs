using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    
    [SerializeField] private Ball ballin;
    [SerializeField] private GameObject ball = null;
    [SerializeField] private GameObject paddle = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent == null)
        {

            Destroy(collision.gameObject);
            Instantiate(ball, paddle.transform.position + new Vector3(0, 0.4f, 0), Quaternion.identity);

        }
        else
        {

            Destroy(collision.transform.parent.gameObject);
            Instantiate(ball, paddle.transform.position + new Vector3(0, 0.4f, 0), Quaternion.identity);

        }
        

        ballin.notLaunch();

    }
}
