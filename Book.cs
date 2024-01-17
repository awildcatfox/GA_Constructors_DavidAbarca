using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_DavidAbarca
{
    public class Book
    {
        // Fields and constructors will go here
        private string title;
        private string author;

        // Default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";


        }










        // Default constructor is implicity created if no constructors are defined
        // Custom constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        // Overload constructor
        // Field Initializion in construsctors ensures objects have valid states
        public Book(string title)
        {

            this.title = title;
            this.author = "No Author Given"; // Default value

        }


        // Properties for Title and Author
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }


    }

 
}
