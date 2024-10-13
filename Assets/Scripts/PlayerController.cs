using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");
        float yDirection = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;

        rigid2D.velocity = direction * speed;
    }
}
