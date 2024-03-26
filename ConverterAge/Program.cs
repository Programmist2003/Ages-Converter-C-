            // Текущая дата
            DateTime Today = DateTime.Today;
 
            // День рождения
            DateTime Birthday = new DateTime(2003, 07, 10);
 
            // Возраст в годах
            int YearCount = 19;
 
            if (Today.Month <= Birthday.Month && Today.Day < Birthday.Day)
            {
                YearCount = Convert.ToInt32(Today.Year - Birthday.Year) - 1;
            }
            else
            {
                YearCount = Convert.ToInt32(Today.Year - Birthday.Year);
            }
            Console.WriteLine(YearCount);