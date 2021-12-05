using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Vector2 pastPosition;
    public float velocity = 1f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Move(Input.mousePosition.x - pastPosition.x);
        }

        pastPosition = Input.mousePosition;
    }

    public void Move(float speed)
    {
        //transform.position += Vector3.right * Time.deltaTime * speed * velocity;
        Vector3 finalposition = transform.position + Vector3.right * Time.deltaTime * speed * velocity;

        if (finalposition.x > 4f)
        {
            finalposition.x = 4f;
        }
        else if (finalposition.x < -2.2)
        {
            finalposition.x = -2.2f;
        }

        transform.position = finalposition;
    }
}
