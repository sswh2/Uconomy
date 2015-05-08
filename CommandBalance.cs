﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDG;
using UnityEngine;
using Rocket.RocketAPI;
namespace unturned.ROCKS.Uconomy
{
    public class CommandBalance : IRocketCommand
    {
        public string Name
        {
            get { return "balance"; }
        }
        public string Help
        {
            get { return "Shows the current balance"; }
        }

        public bool RunFromConsole
        {
            get { return false; }
        }

        public void Execute(RocketPlayer caller,params string[] command)
        {
            decimal balance = Uconomy.Instance.Database.GetBalance(caller.CSteamID);
            RocketChatManager.Say(caller, Uconomy.Instance.Translate("command_balance_show", balance, Uconomy.Instance.Configuration.MoneyName));
        }
    }
}
