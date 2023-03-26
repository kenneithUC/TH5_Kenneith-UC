using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TH4_kenneith_Wijaya
{
    internal class Team 
    {
        private string teamName;
        private string teamCountry;
        private string teamCity;
        public List<Player>player2=new List<Player>();

        public string teamname
        {
            get { return teamName; }
            set { teamName = value; }
        }
        public string teamcountry
        {
            get { return teamCountry; }
            set { teamCountry = value; }
        }
        public string teamcity
        {
            get { return teamCity; }
            set { teamCity = value; }
        }
        public Team(string teamname, string teamcountry, string teamcity)
        {
            this.teamname = teamname;
            this.teamcountry = teamcountry;
            this.teamcity = teamcity;
        }
    }
}
