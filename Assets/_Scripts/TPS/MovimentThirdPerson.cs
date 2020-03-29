using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentThirdPerson : MovimentFirstPerson
{
   
    protected override void Moviment()
    {
        base.Moviment();
        LookInputs();
    }
    void LookMouse()
    {

    }
    void LookInputs()
    {
        transform.LookAt(transform.position + new Vector3(inputMoviment.x, 0, inputMoviment.z));

    }
}
