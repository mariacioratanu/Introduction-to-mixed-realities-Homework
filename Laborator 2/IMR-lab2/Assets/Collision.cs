using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GolfClub")) //tag pt crosă
        {
            FindObjectOfType<GolfScore>().IncrementHits(); //apelam in scriptul de scor
        }
    }
}
