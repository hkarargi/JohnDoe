using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

namespace JohnDoe.JohnDoe.Top.Upgrades
{
    public class SharpenedSword : ModUpgrade<JohnDoeTower>
    {
        public override int Path => Top;
        public override int Tier => 1;
        public override int Cost => 500;
        public override string Description => "John Doe sharpens his sword awaiting his next bloon victim!";
        public override string DisplayName => "Sharpened Sword";
        public override string Name => "SharpenedSword";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            WeaponModel sword = attackModel.weapons[0];
            ProjectileModel swordProjectile = sword.projectile;

            sword.projectile.GetDamageModel().damage += 2;

            if (towerModel.tier == 5)
            {
                sword.projectile.GetDamageModel().damage += 100;
            }
        }
    }
}
