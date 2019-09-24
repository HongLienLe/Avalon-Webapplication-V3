using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AvalonV3.Models;

namespace AvalonV3.Context
{
    public static class DataContextEntension
    {
        public static void CreateSeedData(this DataContext context)
        {
            if (context.Characters.Any())
                return;

            List<Character> ListOfAllCharacters = new List<Character>(){

                new Character(){Id = "1", Name = "Merlin", Team = Team.Good, Description = "Knows Evil", ImagePath = "~/Images/merlin.jpg", ChoosenPlayer = false } ,
                new Character(){Id = "2", Name = "Percival", Team = Team.Good, Description = "Knows Evil",ImagePath = "~/Images/percival.jpg", ChoosenPlayer = false},
                new Character(){Id = "3", Name = "Assassin", Team = Team.Bad, Description = "Assassinate Merlin",ImagePath = "~/Images/assassin.jpg", ChoosenPlayer = false},
                new Character(){Id = "4", Name = "Morgana", Team = Team.Bad, Description = "Appear as Merlin",ImagePath = "~/Images/morgana.jpg", ChoosenPlayer = false},
                new Character(){Id = "5", Name = "Mordred", Team = Team.Bad, Description = "Unknown to Merlin",ImagePath = "~/Images/mordred.jpg", ChoosenPlayer = false},
                new Character(){Id = "6", Name = "Oberon", Team = Team.Bad, Description = "Unknown to Evil",ImagePath = "~/Images/oberon.jpg", ChoosenPlayer = false} };

            context.AddRange(ListOfAllCharacters);
            context.SaveChanges();
        }
    }
}
