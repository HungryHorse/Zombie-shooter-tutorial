using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerFollow : MonoBehaviour {
    public Camera camera;
    public float smoothing = 5.0f;

    void Start()
    {
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        Vector3 newPos = camera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, newPos, (smoothing * 0.1f));
    }
}
