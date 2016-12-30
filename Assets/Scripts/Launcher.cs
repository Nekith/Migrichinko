using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    public float speed;
    public float offset;
    public Transform min;
    public Transform max;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (pos.x <= min.position.x + offset) {
            pos.x = min.position.x + offset;
        } else if (pos.x >= max.position.x - offset) {
            pos.x = max.position.x - offset;
        }
        transform.position = pos;
        if (Input.GetButton("Spawn")) {
            GameObject.Instantiate(Resources.Load("Ball"), transform.position, transform.rotation);
        }
    }
}
