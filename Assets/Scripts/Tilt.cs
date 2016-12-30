using UnityEngine;
using System.Collections;

public class Tilt : MonoBehaviour
{
    public Transform camera;

    private float timer;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        if (timer > 0) {
            timer -= Time.deltaTime;
        } else if (Input.GetButton("Tilt")) {
            Vector3 pos = transform.position;
            pos.x -= 0.5f;
            transform.position = pos;
            pos = camera.position;
            pos.x -= 0.5f;
            camera.position = pos;
            timer = 1;
        }
    }
}
