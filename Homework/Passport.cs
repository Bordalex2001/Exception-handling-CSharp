using System;

namespace Homework
{
    class Passport
    {
        private string number; //номер паспорта
        private string country_code; //код страны
        private string name; //имя владельца
        private string surname; //фамилия владельца
        private char sex; //пол
        private string birthdate; //дата рождения
        private string birthplace; //место рождения
        private string issue_date; //дата выдачи
        private string expiry_date; //конец срока действия
        public Passport(string number = null, string country_code = null, string name = null, string surname = null, char sex = ' ', 
            string birthdate = null, string birthplace = null, string issue_date = null, string expiry_date = null)
        {
            this.Number = number;
            this.CountryCode = country_code; 
            this.Name = name; 
            this.Surname = surname; 
            this.Sex = sex; 
            this.Birthdate = birthdate; 
            this.Birthplace = birthplace; 
            this.IssueDate = issue_date; 
            this.ExpiryDate = expiry_date; 
        }
        public void Print()
        {
            Console.WriteLine($"Passport number: {number}\nCountry code: {country_code}\nName: {name}\nSurname: {surname}\nSex: {sex}" +
                $"\nDate of birth: {birthdate}\nPlace of birth: {birthplace}\nDate of issue: {issue_date}\nDate of expiry: {expiry_date}");
        }
        public string Number
        { 
            get 
            { 
                return this.number; 
            } 
            set
            { 
                try
                {
                    string data = value.ToString();
                    if (value.Length != 8)
                    {
                        throw new Exception("Passport number length cannot be less or greater than 8");
                    }
                    else if (int.TryParse(data, out int only_digits)) //Если забыли ввести буквы;)
                    {
                        throw new Exception("First two signs of the passport number must be letters");
                    }
                    else
                    {
                        this.number = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string CountryCode
        {
            get
            {
                return this.country_code;
            }
            set
            {
                try
                {
                    if (value.Length != 3) 
                    {
                        throw new Exception("Country code is three letters long");
                    }
                    else 
                    { 
                        this.country_code = value; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set 
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо имени
                    {
                        throw new Exception("Name cannot be an Integer or a number");
                    }
                    else
                    {
                        this.name = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Surname
        {
            get
            { 
                return this.surname;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо фамилии
                    {
                        throw new Exception("Surname cannot be an Integer or a number");
                    }
                    else
                    {
                        this.surname = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public char Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                try
                {
                    if(value != 'M' && value != 'F')
                    {
                        throw new Exception("Please write M (male) or F (female) in the sex field");
                    }
                    else
                    {
                        this.sex = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Birthdate
        {
            get
            { 
                return this.birthdate;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if(!DateTime.TryParse(date, out DateTime valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of birth is not valid");
                    }
                    else
                    {
                        this.birthdate = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Birthplace
        {
            get
            { 
                return this.birthplace;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо букв и знаков пунктуации
                    {
                        throw new Exception("Place of birth cannot be an Integer or a number");
                    }
                    else if(value.Length > 50)
                    {
                        throw new Exception("Too many letters in the field \"Place of birth\"");
                    }
                    else
                    {
                        this.birthplace = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string IssueDate
        {
            get
            {
                return this.issue_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of issue is not valid");
                    }
                    else
                    {
                        this.issue_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string ExpiryDate
        {
            get
            { 
                return this.expiry_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of expiry is not valid");
                    }
                    else
                    {
                        this.expiry_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
}
