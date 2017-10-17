using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : IEnemyController {
    Enemy _enemy;


    public EnemyController(Enemy enemy)
    {
        _enemy = enemy;
   
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Setup()
    {
        _enemy.Scale = new Vector3(1f, 1f, 1f);
    }
    public void CaptureInput()
    {
        Vector3 positions = new Vector3(_enemy.Position.x, Mathf.Lerp(3.9f, -6f,Time.time*0.1f), _enemy.Position.z);
        _enemy.Position = positions;
    
    }
}
