using UnityEngine;
using UnityEngine.SceneManagement;
public class Death_Area : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene(0);
        }
    }
}
