using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;            //

namespace WebApplication2.Models
{
    public class DynamicModel
    {
        [Required(ErrorMessage = "Name Thy Player!!!")]
        public string PlayerName { get; set; }


        public void Create(string playername)
        {
            var player = new DynamicModel();
            player.PlayerName = playername;
            Globals.Players.Add(player);
        }
    }
}