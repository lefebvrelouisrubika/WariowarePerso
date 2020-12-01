using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gabarit : MonoBehaviour
{
    [SerializeField]
    private float baseSpeed;
    [SerializeField]
    private float speedModifier;
    public GameObject Player;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = (Player.transform.position - transform.position).normalized * (baseSpeed * speedModifier);
    }
}
