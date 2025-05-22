using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");  
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
    }
}