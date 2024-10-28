using UnityEngine;
using UnityEngine.U2D;

public class Block_Controller : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private int health;

    private void Start()
    {
        NextBlockSprite();
    }

    private void NextBlockSprite()
    {
        Sprite NexstSprite = sprites[health-1];
        GetComponent<SpriteRenderer>().sprite = NexstSprite;
    }

    private void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }else
        {
            NextBlockSprite();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            TakeDamage();
        }
    }
}
