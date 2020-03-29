using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public StatsEnemys statsEnemy;

    public Transform playerDistance;
    public float distanceBtw;

    private void Awake()
    {
        statsEnemy.rb = GetComponent<Rigidbody>();
        playerDistance = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        Moviment();
    }
    void Update()
    {
        
    }
    protected virtual void Moviment()
    {
        distanceBtw = Vector3.Distance(transform.position, playerDistance.position);

    }
    void Death()
    {

    }
    void Attack()
    {

    }

    
}
