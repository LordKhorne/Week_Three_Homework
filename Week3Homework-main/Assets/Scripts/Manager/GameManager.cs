using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private GameObject piecePrefab = null;

    void Start()
    {
        //TODO
        //Using const data defined above "Instantiate" new pieces to fill the view with
        for(int i = 0; i < TOTAL_ROWS; i++)
        {
            for(int j = 0; j < PIECE_COUNT_PER_ROW; j++)
            {

                Instantiate(piecePrefab, new Vector3(-6.0f + (j * PIECE_LENGTH), 4.75f - (i * ROW_HEIGHT)), Quaternion.identity);

            }

        }

    }

}
