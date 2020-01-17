using System;

namespace cw
{
    public class Person
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(int id, string name, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
        }

        public void SetAddress(string newAddress)
        {
            this.Address = newAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $@"
			ID: {this.ID}
			Name: {this.Name} 
			Address: {this.Address}
		    ";
        }
    }
}