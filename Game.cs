using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_DavidAbarca
{
    public class Game
    {
        // Fields and constructors will go here
        private string title;
        private string dev;

        // Default constructor
        public Game()
        {
            title = "Unknown";
            dev = "Unknown";


        }










        // Default constructor is implicity created if no constructors are defined
        // Custom constructor
        public Game(string title, string dev)
        {
            this.title = title;
            this.dev = dev;
        }

        // Overload constructor
        // Field Initializion in construsctors ensures objects have valid states
        public Game(string title)
        {

            this.title = title;
            this.dev = "No Developer Given"; // Default value

        }


        // Properties for Title and Author
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Developer
        {
            get { return dev; }
            set { dev = value; }
        }








    }
}
