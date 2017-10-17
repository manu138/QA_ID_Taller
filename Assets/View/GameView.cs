using System;
using UnityEngine;
using Zenject;

public class GameView : ITickable, IInitializable
{
    IShipController _shipController;
    bool _isShipReady;

    IEnemyController _enemyController;
    bool _isEnemyReady;

    public GameView(IShipController tankController,IEnemyController enemyController)
    {
        _shipController = tankController;
        _enemyController = enemyController;
    }

    public void Initialize()
    {
        _shipController.Setup();
        _enemyController.Setup();
    }

    public void Tick()
    {
        if(_isShipReady)
        {
            _shipController.CaptureInput();
            _enemyController.CaptureInput();
        }

        _isShipReady = _shipController.AnimateTankStep();
    }
}
