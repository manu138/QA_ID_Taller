using UnityEngine;
using System.Collections;
using Zenject;
using System.Linq;

public class MainInstaller : MonoInstaller
{
    public GameObject MissilePrefab;
    public GameObject TankPrefab;
    public GameObject EnemyPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Spaceship>().ToSinglePrefab(TankPrefab);
        Container.BindGameObjectFactory<GameObjectFactory<Missile>>(MissilePrefab);

        Container.Bind<Enemy>().ToSinglePrefab(EnemyPrefab);
        Container.Bind<IEnemyController>().ToSingle<EnemyController>();

        Container.BindAllInterfacesToSingle<GameView>();
        Container.Bind<IShipController>().ToSingle<ShipController>();
        Container.Bind<IMissileController>().ToSingle<MissileController>();
    }
}
