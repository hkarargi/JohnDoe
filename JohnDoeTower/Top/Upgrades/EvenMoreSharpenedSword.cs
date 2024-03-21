using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

namespace JohnDoe.JohnDoe.Top.Upgrades
{
    public class EvenMoreSharpenedSword : ModUpgrade<JohnDoeTower>
    {
        public override int Path => Top;
        public override int Tier => 2;
        public override int Cost => 750;
        public override string Description => "John Doe sharpens his sword awaiting his next bloon victim!";
        public override string DisplayName => "Even More Sharpened Sword";
        public override string Name => "EvenMoreSharpenedSword";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            WeaponModel sword = attackModel.weapons[0];

            sword.projectile.GetDamageModel().damage += 5;

            if (towerModel.tier == 5)
            {
                sword.projectile.GetDamageModel().damage += 250;
            }
        }
    }
}
