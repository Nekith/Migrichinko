using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public float bumpFactor;
    public float ballFactor;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bump") {
            GetComponent<Rigidbody2D>().AddForce(collision.relativeVelocity * -1 * bumpFactor);
        } else if (collision.gameObject.tag == "Ball") {
            Vector2 v = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
            GetComponent<Rigidbody2D>().AddForce(v.normalized * ballFactor);
        }
    }
}
