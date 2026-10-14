using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Werkzeugausgabe
{
    internal class Tool
    {
        private string description;
        private int id;
        private bool isAvailable;

        
        

        public void SetDescription(string description)
        {
            this.description = description;

        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetIsAvailable(bool isAvailable)
        {
            this.isAvailable = true;
        }
        public void Print()
        {
            Console.WriteLine($"Beschreibung: {description}, ID: {id}, Verfügbar: {isAvailable}");
        }
        public void SetFalse() 
        {
            isAvailable=false;
            
        }
        public void SetTrue() 
        {
            isAvailable=true;
        }

    }
}
