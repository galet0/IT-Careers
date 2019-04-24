using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_10_04_FootballTeam
{
    class Team
    {
        //има променлив брой играчи, име и рейтинг
        private string name;
        private List<Player> players;
        private int rating;
        //Отборът трябва да показва име, рейтинг 

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }

                this.name = value;
            }
        }

        public List<Player> Players
        {
            get { return this.players; }
        }

        //методи за добавяне и премахване на играчи
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Boolean isRemoved = false;

            for (int i = 0; i < this.Players.Count; i++)
            {
                if (this.Players[i].Name.Equals(playerName))
                {
                    this.players.Remove(this.Players[i]);
                    isRemoved = true;
                }
            }

            if (!isRemoved)
            {
                throw new ArgumentException($"Player {playerName} is not in Arsenal");
            }
        }
        //(изчислена от нивата на средните умения на всички 
        //играчи в отбора и закръглена до цяло число)
        private int CalculateRating()
        {
            return this.Players.Sum(p => p.GetSkillLevel());
        }

        public int GetRating()
        {
            return CalculateRating();
        }

    }
}
