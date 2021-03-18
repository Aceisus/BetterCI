using Synapse;
using Synapse.Api;
using Synapse.Api.Plugin;

namespace Synapse.Api.Items
{
    public class Logicer2 : AbstractPlugin
    {

        public override void Load()
        {
            var info = new Synapse.Api.Items.CustomItemInformation()
            {
                BasedItemType = ItemType.GunLogicer,
                ID = 100,
                Name = "Logicer-KR18",
            
            };

            Server.Get.ItemManager.RegisterCustomItem(info);
        }

    }
}

