using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : BasicDPS
{
    //Ссылки на компоненты
    private Rigidbody2D rb;
    //Изменяемы компоненты
    [SerializeField]private float speed;
    //Нечто
    private Vector2 moveVelocity;
    private Vector2 moveInput;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        MoveLogic();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    private void MoveLogic()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
}
