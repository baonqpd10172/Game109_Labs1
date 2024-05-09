using System;

    public class Maps
    {
        public string id;
        public string userName;
        public static string _inGame = "lien minh huyen thoai";

        public Maps(string id, string userName)
        {
            this.id = id;
            this.userName = userName;
        }
        public string ShowData()
        {
            return "ID : " + id + "|Name:" + userName + "|inGame:" + _inGame;
        }
    }

