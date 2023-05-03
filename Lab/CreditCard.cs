using System;

namespace Lab
{
    class CreditCard
    {
        public string CardNumber
        {
            get
            {
                return this.card_number;
            }
            set
            {
                try
                {
                    if (value.Length != 16)
                    {
                        throw new Exception("Total card number length cannot be less or greater than 16");
                    }
                    else
                    {
                        this.card_number = value;
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
                    if(int.TryParse(data, out int not_letters)) //Ввод числа вместо имени
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
        public int CVVCode 
        { 
            get
            {
                return this.cvv_code;
            }
            set
            {
                try
                {
                    if (value < 100 || value >= 1000)
                    {
                        throw new Exception("Value of a CVV code cannot be less than 100 or greater than 999");
                    }
                    else
                    {
                        this.cvv_code = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public int Month
        { 
            get
            {
                return this.month;
            }
            set
            {
                try
                {
                    if (value < 1 || value > 12)
                    {
                        throw new Exception("Value of a month cannot be less than 1 or bigger than 12; ");
                    }
                    else
                    {
                        this.month = value;
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"{ex.Message}");
                }
            }
        
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 99)
                    {
                        throw new Exception("Last two digits of the year cannot be negative or greater than 99");
                    }
                    else
                    {
                        this.year = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

        }
        public double PersonalFunds 
        { 
            get
            {
                return this.personal_funds;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Value of personal funds cannot be negative");
                    }
                    else
                    {
                        this.personal_funds = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public double CreditLimit
        {
            get
            {
                return this.credit_limit;
            }
            set
            {
                this.credit_limit = value;
            }
        }
        private string card_number; //номер карты
        private string name; //имя владельца
        private string surname; //фамилия владельца
        private int cvv_code; //CVV-код или CVC
        private int month; //месяц завершения работы
        private int year; //год завершения работы
        private double personal_funds; //собственные средства
        private double credit_limit; //кредитный лимит (кредит)
        public CreditCard(string card_number = null, string name = null, string surname = null, int cvv_code = 0,
            int month = 0, int year = 0, double personal_funds = 0.0, double credit_limit = 0.0)
        {
            this.CardNumber = card_number;
            this.Name = name;
            this.Surname = surname;
            this.CVVCode = cvv_code;
            this.Month = month;
            this.Year = year;
            this.PersonalFunds = personal_funds;
            this.CreditLimit = credit_limit;
        }
        public void Print()
        {
            Console.WriteLine($"Card number: {card_number}\nHolder: {name}  {surname}\nCVV code: {cvv_code}\nValidity: {month}/{year}\nPersonal funds: {personal_funds}\nCredit limit: {credit_limit}");
        }
    }
}