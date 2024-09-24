using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    public override void AttackPlayer()
    {
        print("Goblin is attacking player");
    }
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
