using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        private int morning = 9;
        private int afternoon = 13 ;
        private int evening = 17;
        private IDateTime userDate;


        //public Message(int matin, int aprem, int soir)
        //{
        //    morning = matin;
        //    afternoon = aprem;
        //    evening = soir;
        //}

        public Message() // Constructeur avec date du jour
            :this(new RealDateTime())
        {

        }

        public Message(IDateTime date) // Constructeur utilisant l'interface pour les tests
        {
            userDate = date;
        }

        
        public string GetHelloMessage()
        {
            string message = String.Empty;// Identique à : (string message = "";)
            String userName = System.Environment.UserName;
            DayOfWeek userDay = userDate.Date.DayOfWeek; // Donne le nom du jour correspondant à la date du jour
            int userTime = userDate.Date.Hour;// Donne l'heure courante

            if (
                (userDay == DayOfWeek.Saturday) || (userDay == DayOfWeek.Sunday)
                || (userDay == DayOfWeek.Friday && userTime >= evening)
                || (userDay == DayOfWeek.Monday && userTime< morning)
                )
            {
                message = "Bon week-end " + userName + " ! ";
            }
            else
            {
                if (userTime > evening)
                {
                    message = "Bonsoir " + userName + " ! ";
                }
                else if (userTime >= afternoon)
                {
                    message = "Bon après-midi " + userName + " ! ";
                }
                else if (userTime >= morning)
                {
                    message = "Bonjour " + userName + " ! ";
                }
            }

            return message;            
        }
    }
}
