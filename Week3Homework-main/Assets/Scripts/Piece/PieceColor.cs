using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField] 
    private Sprite[] Colors = null;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {

        int randomColor = Random.Range(0, 6);

        spriteRenderer.sprite = Colors[randomColor];

    }
}
