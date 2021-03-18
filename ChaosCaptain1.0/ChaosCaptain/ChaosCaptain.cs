using Synapse;
using Synapse.Api.Roles;
using Synapse.Api.Items;
using System.Collections.Generic;

namespace NewRole
{
    public class NewRoleName : Synapse.Api.Roles.Role
    {
        public override int GetRoleID() => 20; 

        public override string GetRoleName() => "Chaos Captain";

        public override Team GetTeam() => Team.CHI;

        public override void Spawn() 
        {
            Player.RoleType = RoleType.ChaosInsurgency;
            Player.MaxHealth = 200;
            var item = new SynapseItem(ItemType.GunLogicer, 10, 0, 0, 3);
            item.PickUp(Player);
            
        }
        public override void DeSpawn()
        {
            Player.SendBroadcast(5, "You are no longer a Chaos Captain");
        }

        public override List<Team> GetFriends() => new List<Team> { Team.CDP, Team.RSC };


        public virtual List<Team> GetEnemys() => new List<Team> { Team.MTF }; //This means this Role and MTF must kill each other or else the round will not end
   
    }

}