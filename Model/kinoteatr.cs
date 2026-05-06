namespace Kino_Bartova.Model
{
    public class kinoteatr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountZal { get; set; }
        public int Count { get; set; }

        public kinoteatr(int Id, string Name, int CountZal, int Count)
        {
            this.Id = Id;
            this.Name = Name;
            this.CountZal = CountZal;
            this.Count = Count;
        }

    }
}
