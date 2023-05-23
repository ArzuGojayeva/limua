namespace ConsoleApp2.Models
{
    internal class Store
    {
        private string _name;
        public string StrName {
            get { return _name; }
            set
            {
                if (value.Length > 2)
                {
                    _name= value;
                }
            }
            }
        public Store(string name)
        {
            StrName =name;
        }
                

        private Phone[] Phones = new Phone[0];
        public void Addphone(Phone phone)
        {
            Array.Resize(ref Phones,Phones.Length+1);
            Phones[Phones.Length - 1] = phone;
        }
        public void ShowAllPhone()
        {
            if(Phones.Length > 0)
            {
                foreach (Phone phone in Phones)
                {
                    Console.WriteLine(phone.Name +" "+ phone.Price);
                }
            }
            else
            {
                Console.WriteLine("Telefon yoxdur");
            }
            
        }
        public void ShowPhone(int min,int max) 
        {
            if (Phones.Length > 0)
            {
                foreach (Phone phone in Phones)
                {
                    if(phone.Price<max && phone.Price > min)
                    {
                        Console.WriteLine(phone.Name, phone.Price);

                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Telefon yoxdur");
            }

        }
        public void RemovePhone(int id)
        {
            Phone[]pones = new Phone[0];
            foreach(Phone phone in Phones)
            {
                if (phone.Id != id)
                {
                    Array.Resize(ref pones, pones.Length + 1);
                    pones[pones.Length-1] = phone;
                }
            }
            Phones=pones;
        }
    }
}
