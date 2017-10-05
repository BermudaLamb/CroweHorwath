namespace CroweHorwath.Models
{
    public class HelloWorld
    {
        public HelloWorld()
        {
            value = "Hello World";
        }

        private string value;
        public virtual string Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
