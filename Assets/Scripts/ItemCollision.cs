using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    public float speed = 3f;  // سرعت حرکت آیتم
    public GameObject itemPrefab; // ارجاع به Prefab آیتم
    public float spawnInterval = 2f;  // فاصله زمانی بین تولید آیتم‌ها
    public float minX = -4f, maxX = 4f;  // محدوده تصادفی تولید آیتم
    public float spawnY = 5f;  // موقعیت Y برای شروع آیتم‌ها

    void Start()
    {
        if (itemPrefab != null) // بررسی اینکه Prefab اختصاص داده شده باشد
        {
            InvokeRepeating("SpawnItem", 0f, spawnInterval);
        }
    }

    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0); // حرکت آیتم به پایین
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // بررسی برخورد آیتم با کاراکتر
        {
            Debug.Log("آیتم گرفته شد!");
            Destroy(gameObject); // حذف آیتم
        }
    }

    void SpawnItem()
    {
        float randomX = Random.Range(minX, maxX); // انتخاب یک موقعیت تصادفی X
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0); // تنظیم موقعیت آیتم جدید
        Instantiate(itemPrefab, spawnPosition, Quaternion.identity); // ایجاد آیتم جدید
    }
}