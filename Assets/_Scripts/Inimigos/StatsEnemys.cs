using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy",menuName = "Enemy")]
public class StatsEnemys : ScriptableObject
{

    public Inimigos inimigos;
    
    public int healf;
    public float movimentSpeed;
  //  public float distanceToWalk;
    public float distanceToStop;
    public float distanceToRetreat;
    public float distanceToFind;

    public string myName;

    
    public Rigidbody rb;
    public Collider collider;
    

}
