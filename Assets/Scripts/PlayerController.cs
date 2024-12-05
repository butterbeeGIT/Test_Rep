using Unity.VisualScripting;
using UnityEngine;
public class PlayerController : MonoBehaviour 
{
    public float moveSpeed = 5f; // Скорость перемещения персонажа.
    public Animator anime;
    public Rigidbody2D rb;
    public bool faceRight = true;

    private void Update()
    {
        // Получаем значения клавиш WASD.
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Вычисляем вектор перемещения.
        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;

        if ((movement.x > 0 && !faceRight) || (movement.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }

        rb.MovePosition(rb.position + movement);
    }
}