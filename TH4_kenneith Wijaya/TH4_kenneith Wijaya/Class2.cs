using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH4_kenneith_Wijaya
{
    internal class Player
    {
        private string playerName;
        private string playerNum;
        private string playerPos;

        public string playername
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string playernumber
        {
            get { return playerNum; }
            set { playerNum = value; }
        }
        public string playerposition
        {
            get { return playerPos; }
            set { playerPos = value; }
        }

        public Player(string playername, string playernumber, string playerposition)
        {
            this.playername = playername;
            this.playernumber = playernumber;
            this.playerposition = playerposition;
        }
    }
}
