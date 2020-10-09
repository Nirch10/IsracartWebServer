using System.Reflection.Metadata;
namespace Models
{
    public class Task : Iparsable<Task>
    {
        public string Name { get; set; }
        public string PhotoPath { get; set; }

        public Task(string name, string photoPath = "")
        {
            Name = name;
            PhotoPath = photoPath;
        }

        public Task(){
            Name = "";
            PhotoPath = "";
        }

        public Task Parse(params string[] dataToParse)
        {
            if(dataToParse.Length != 2)
                return null;
            Name = dataToParse[0];
            PhotoPath = dataToParse[1];
            return this;    
        }

    }
}