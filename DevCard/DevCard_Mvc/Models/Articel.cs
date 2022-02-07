namespace DevCard_Mvc.Models
{
    public class Articel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Articel(int id , string title , string dec)
        {
            Id = id;
            Title = title;
            dec = Description;
        }
    }
}
