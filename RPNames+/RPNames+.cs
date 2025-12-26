using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace RPNamesPlus
{
    public class RPNamesPlus : Plugin<Config>
    {
        public override string Author => "Shibusekk";
        public override string Name => "RPNames+";
        public override string Prefix => "RPNames+";
        public override Version Version => new Version(1, 0, 2);
        public override Version RequiredExiledVersion => new Version(9, 9, 2);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole += OnChangingRole;
            Log.Info("RPNames+ has been enabled. Thank you for using my plugin.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= OnChangingRole;
            base.OnDisabled();
        }

        private void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleTypeId.Spectator || ev.NewRole == RoleTypeId.Overwatch)
            {
                ev.Player.DisplayNickname = ev.Player.Nickname;
                return;
            }

            ApplyRoleplayName(ev.NewRole, ev.Player);
        }

        private void ApplyRoleplayName(RoleTypeId role, Player player)
        {
            string roleName = role.ToString();

            if (role == RoleTypeId.ClassD)
            {
                string dNumber = UnityEngine.Random.Range(1000, 10000).ToString();
                player.DisplayNickname = "D-" + dNumber;
                return;
            }

            if (!Config.rpnamesplus.ContainsKey(roleName))
                return;

            var roleConfig = Config.rpnamesplus[roleName];
            if (roleConfig.Names == null || roleConfig.Names.Count == 0)
                return;

            string randomName = roleConfig.Names[UnityEngine.Random.Range(0, roleConfig.Names.Count)];
            player.DisplayNickname = roleConfig.Prefix + randomName;
        }
    }
}
