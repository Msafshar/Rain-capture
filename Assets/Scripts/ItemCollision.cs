using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0); // حرکت آیتم به پایین
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // بررسی برخورد با کاراکتر
        {
            Debug.Log("آیتم گرفته شد!");
            Destroy(gameObject); // حذف آیتم
        }
    }
}