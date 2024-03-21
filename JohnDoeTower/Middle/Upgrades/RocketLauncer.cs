using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Unity;

namespace JohnDoe.JohnDoe.Top.Upgrades
{
    public class RocketLauncher : ModUpgrade<JohnDoeTower>
    {
        public override int Path => Top;
        public override int Tier => 1;
        public override int Cost => 500;
        public override string Description => "John Doe sharpens his sword awaiting his next bloon victim!";
        public override string DisplayName => "Rocket Launcher";
        public override string Name => "RocketLauncher";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.AddBehavior(Game.instance.model.GetTowerFromId("BombTower-000").GetWeapon().Duplicate());
            WeaponModel sword = attackModel.weapons[0];
            WeaponModel rocket = attackModel.weapons[1];
        }
    }
}
