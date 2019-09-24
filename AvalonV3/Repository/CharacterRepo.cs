using System;
using Microsoft.EntityFrameworkCore;
using AvalonV3.Context;
using AvalonV3.Models;
using System.Collections.Generic;
using System.Linq;

namespace AvalonV3.Repository
{
    public class CharacterRepo
    {
        private DataContext Context;

        public CharacterRepo(DataContext context)
        {
            Context = context;
        }

        public List<Character> GetAllCharacters()
        {
            return Context.Characters.ToList();
        }

        public Character GetCharacter(string? id)
        {
            using(var context = Context)
            {
                return context.Characters.Find((string)id);
            }
        }

        public void UpdateCharacter(Character character)
        {
            using (var context = Context)
            {
                context.Characters.Attach(character);

                var characterEntry = context.Entry(character);

                characterEntry.State = EntityState.Modified;
                characterEntry.Property("Name").IsModified = false;
                characterEntry.Property("Team").IsModified = false;
                characterEntry.Property("Id").IsModified = false;
                characterEntry.Property("Description").IsModified = false;
                characterEntry.Property("ImagePath").IsModified = false;


                context.SaveChanges();

            }
        }
    }
}
