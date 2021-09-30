using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Bookish_dataAccess
{
    public class LibraryRepository
    {
        private string connectionString = @"Server=localhost;Database=bookish;Trusted_Connection=True;";

        public IEnumerable<Book> GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>("SELECT * FROM dbo.Books");
        }

        public IEnumerable<Book> SearchBooks(string searchText)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<Book>($"SELECT * FROM Books WHERE Title LIKE '%{searchText}%' OR Author LIKE '%{searchText}%'");
        }

        public Book GetBook(int BookId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.QuerySingle<Book>($"SELECT * FROM dbo.Books WHERE BookId = {BookId}");
        }

        public IEnumerable<BookCopies> GetCopiesBorrowedByUser(int UserId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection.Query<BookCopies>($"SELECT * FROM Copies WHERE UserId = {UserId}");
        }
    }
}

