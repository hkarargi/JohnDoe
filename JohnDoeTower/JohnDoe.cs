using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

namespace JohnDoe.JohnDoe
{
    public class JohnDoeTower : ModTower
    {
        public override string Name => "JohnDoe";
        public override string DisplayName => "John Doe";
        public override string Description => "John Doe the infamous rumored hacker is here in BTD6!";
        public override string BaseTower => "DartMonkey";
        public override int Cost => 500;
        public override int TopPathUpgrades => 2;
        public override int MiddlePathUpgrades => 1;
        public override int BottomPathUpgrades => 0;
        public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Military; 
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            WeaponModel sword = attackModel.weapons[0];
            
            sword.projectile.pierce = 1;
            sword.projectile.GetDamageModel().distributeToChildren = true;
            sword.projectile.GetDamageModel().damage = 3;
            sword.projectile.AddBehavior(new AgeModel("AgeModelSword_",0.05f,1,false,null));
            sword.projectile.AddBehavior(new FilterInvisibleModel("FilterInvisibleModel_", true, false));
        }
        public override bool IsValidCrosspath(params int[] tiers) => true;
    }
}
