using BTD_Mod_Helper;
using MelonLoader;

[assembly: MelonInfo(typeof(JohnDoe.Main), JohnDoe.ModHelperData.Name, JohnDoe.ModHelperData.Version, JohnDoe.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace JohnDoe
{
    public class Main : BloonsTD6Mod
    {
    }
}
