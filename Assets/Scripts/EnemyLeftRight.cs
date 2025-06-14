using UnityEngine;

public class EnemyLeftRight : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    private Vector2 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Рух ліво-вправо
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        // Зміна напрямку при досягненні межі
        if (Mathf.Abs(transform.position.x - startPosition.x) >= moveDistance)
        {
            direction *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Гравець отримав урон!");
            collision.GetComponent<PlayerHealth>().TakeDamage(1);
            
            // Більше не знищуємо ворога!
            // Destroy(gameObject);
        }
    }
}
