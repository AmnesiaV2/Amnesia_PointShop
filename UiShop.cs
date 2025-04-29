using _menu = AAMenu.Menu;
using Life.UI;
using Life.CheckpointSystem;
using Life.DB;
using Life.Network;
using Mirror;
using ModKit.Helper;
using ModKit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Amnesia_Couleurs.Utils;
using Life;
using DShop.Data;
using Steamworks.Ugc;
using ModKit.Helper.PointHelper;

namespace Amnesia_UiShop
{
    public class UiShop : ModKit.ModKit
    {
        public UiShop(GameAPI aPI) : base(aPI) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            InsertMenu();

            new SChatCommand("/uishop", "", "/uishop", (Player player, string[] arg) =>
            {
                if (player.account.AdminLevel >= 5)
                {
                    MenuPrincipal(player);
                }
                else
                {
                    player.Notify(Couleurs.Violet("AMNESIA ADMIN"), "Vous n'avez pas le rang nécessaire pour pouvoir effectuer cette action.", NotificationManager.Type.Error);
                }
            });

        }

        public void InsertMenu()
        {
            _menu.AddAdminPluginTabLine(PluginInformations, 5, Couleurs.Violet("Amnesia • Shop"), (ui) =>
            {
                Player player = PanelHelper.ReturnPlayerFromPanel(ui);
                MenuPrincipal(player);
            });
        }


        public void MenuPrincipal(Player player)
        {
            Panel panel = PanelHelper.Create("AMNESIA_MENU", UIPanel.PanelType.TabPrice, player, () => MenuPrincipal(player));

            panel.AddTabLine("Modèle", ui =>
            {
                MenuModèle(player);
            });
            panel.AddTabLine("Point", ui =>
            {

            });

            panel.CloseButton();
            panel.AddButton("Selectionner", async ui =>
            {
                player.ClosePanel(ui);
                await Task.Delay(10);
                panel.SelectTab();
            });
            panel.Display();
        }

        public async void MenuModèle(Player player)
        {
            Panel panel = PanelHelper.Create("Choisir un modèle", UIPanel.PanelType.Tab, player, () => MenuModèle(player));

            var allElements = await DataShop_Pattern.QueryAll();

            foreach(var element in allElements)
            {
                panel.AddTabLine($"{element.PatternName}", ui => { });
            }
        }
    }
}
