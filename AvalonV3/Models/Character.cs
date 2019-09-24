using System;
namespace AvalonV3.Models
{
    public class Character
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool ChoosenPlayer { get; set; }

    }

    public enum Team
    {
        Good = 1,
        Bad = 2
    }
}
