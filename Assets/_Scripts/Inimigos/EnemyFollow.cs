using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : Inimigos
{
    protected override void Moviment()
    {
        base.Moviment();
        transform.LookAt(playerDistance.position);

        if (distanceBtw > statsEnemy.distanceToStop && distanceBtw < statsEnemy.distanceToFind)
        {
            //statsEnemy.rb.MovePosition(Vector3.MoveTowards(transform.position, playerDistance.position, statsEnemy.movimentSpeed * Time.deltaTime));
            transform.position = Vector3.MoveTowards(transform.position,playerDistance.position,statsEnemy.movimentSpeed * Time.deltaTime);

        }
        else if (distanceBtw <= statsEnemy.distanceToStop && distanceBtw > statsEnemy.distanceToRetreat)
        {
            transform.position = transform.position;
        }
        else if (distanceBtw < statsEnemy.distanceToRetreat)
        {
           // transform.position = Vector3.MoveTowards(transform.position, playerDistance.position, -statsEnemy.movimentSpeed * Time.deltaTime);

        }
    }
}
