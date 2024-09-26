using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Renderer myGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
    void OnMouseOver()
    {
        myGameObject.material.color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        myGameObject.material.color = Color.white;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
