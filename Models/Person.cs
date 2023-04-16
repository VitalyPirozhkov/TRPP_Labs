namespace TBPP_LABS.Models
{
    /// <summary>
    /// Класс представляющий человека.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID человека.
        /// </summary>
        public double id { get; set; }

        /// <summary>
        /// Имя человека.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        public string MidName { get; set; }

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        public string LastName { get; set; }


        /// <summary>Создает новый экземпляр класса Person с заданными именем, фамилией и датой рождения.</summary>
        /// <param name="firstName">Имя человека.</param>
        /// <param name="lastName">Фамилия человека.</param>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Возвращает полное имя человека в формате "Имя Фамилия".
        /// </summary>
        /// <returns>Полное имя человека.</returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}