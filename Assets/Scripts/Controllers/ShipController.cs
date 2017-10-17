using UnityEngine;
using System.Collections;
using Zenject;
using System;

public class ShipController : IShipController
{
    Spaceship _ship;
    IMissileController _missileController;

    public ShipController(Spaceship ship, IMissileController missileController)
    {
        _ship = ship;
        _missileController = missileController;
    }

    public void Setup()
    {
        _ship.Scale = new Vector3(2f, 2f, 2f);
    }

    public bool AnimateTankStep()
    {
        if(_ship.Scale == new Vector3(0.1f, 0.1f, 0.1f))
        {
            return true;
        }
        else
        {
            _ship.Scale -= new Vector3(0.1f, 0.1f, 0.1f);
            return false;
        }
    }

    public void CaptureInput()
    {
        float speed=5f;
         float moveHorizontal = Input.GetAxis("Horizontal");
        float  moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,moveVertical, 0.0f);
       _ship.Rigidbody.velocity = movement * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _missileController.CreateMissile(_ship.Position, _ship.Rotation);
        }
    }



}
