namespace CURSO_CSHARP_NELIO_ALVES.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}