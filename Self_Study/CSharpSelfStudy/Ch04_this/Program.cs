namespace Ch04_this
{
    internal class Program
    {
        class Book
        {
            decimal _isbn;
            public decimal ISBN
            {
                get { return this._isbn; }
            }

            public Book(decimal isbn)
            {
                this._isbn = isbn;
            }

            public decimal GetISBN()
            {
                return this.ISBN;
            }

            public void Sell()
            {
                Console.WriteLine("Sell: " + this.GetISBN());
            }
        }

        // this 예약어 사용해서 생성자 내에서 다른 생성자 호출
        class Book1
        {
            string title;
            decimal isbn13;
            string author;

            public Book1(string title) : this(title, 0)
            {

            }
            public Book1(string title, decimal isbn13) : this(title, isbn13, string.Empty)
            {

            }
            public Book1(string title, decimal isbn13, string author)
            {
                this.title = title;
                this.isbn13 = isbn13;
                this.author = author;
            }
            public Book1() : this(string.Empty, 0, string.Empty)
            {

            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
