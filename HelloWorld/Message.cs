using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Message
    {
        private int morning = 9;
        private int afternoon = 13 ;
        private int evening = 18;

        public Message(int matin, int aprem, int soir)
        {
            morning = matin;
            afternoon = aprem;
            evening = soir;
        }
    
        public void GetHelloMessage()
        {
            String userName = System.Environment.UserName;
            DateTime userDate = DateTime.Now;// Récupère la date du jour
            DayOfWeek userDay = userDate.DayOfWeek; // Donne le jour correspondant à la date du jour
            int userTime = userDate.Hour;// Donne l'heure courante

            if (
                (userDay == DayOfWeek.Saturday) || (userDay == DayOfWeek.Sunday)
                || (userDay == DayOfWeek.Friday && userTime >= evening)
                || (userDay == DayOfWeek.Monday && userTime< morning)
                )
            {
                Console.WriteLine("Bon week-end " + userName + " ! ");
            }
            else
            {
                if (userTime > evening)
                {
                    Console.WriteLine("Bonsoir " + userName + " ! ");
                }
                else if (userTime >= afternoon)
                {
                    Console.WriteLine("Bon après-midi " + userName + " ! ");
                }
                else if (userTime >= morning)
                {
                    Console.WriteLine("Bonjour " + userName + " ! ");
                }
            }

            Console.WriteLine("Jour : " + userDay);
            Console.WriteLine("Heure : " + userTime);
        }
    }
}
