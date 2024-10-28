using UnityEngine;

public class Ball_Cpntroller : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1f,1f) * 300f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DeathArea")
        {
            gameManager.RestartGame();
        }
    }
}
