namespace mis221_bonus_lab_cwray2
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;

        public Book()
        {

        }

        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            this.isbn = tempIsbn;
            this.title = tempTitle;
            this.author = tempAuthor;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public override string ToString()
        {
            return "ISBN = " + this.isbn + ", Title = " + this.title + ", Author: " + author.ToString();
        }
    }
}