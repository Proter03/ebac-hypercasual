using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float velocity = 1f;

    private Vector2 _pastPosition;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // mousePosition AGORA - mousePosition PASSADO
            Move(Input.mousePosition.x - _pastPosition.x);
        }

        _pastPosition = Input.mousePosition;
    }

    private void Move(float speed)
    {
        transform.position += Vector3.right * Time.deltaTime * speed * velocity;
    }
}
