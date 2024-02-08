/**========================================
Professor Kemoy Campbell
Author: Rahul Yadav
NACA.121
February 7, 2024
==========================================**/


using System.ComponentModel.DataAnnotations;

public class Book
{
    //set up attributes
    public string title;
    public string author;
    public int pages;

    private int pagesRead;

    //Default constructor
    public Book()
    {
        title = "Unspecified";
        author = "N/A";
        pages = 0;
        pagesRead = 0;
    }

    //Paramterized constructor
    public Book(string titleName, string authorName, int pageNumber)
    {
        title = titleName;
        author = authorName;
        pages = pageNumber;
        pagesRead = 0;
    }

    //ToString override
    public override string ToString()
    {
        return $"Book 1\nTitle: {title}\nAuthor: {author}\nPages: {pages}\nPagesRead: {pagesRead}";
    }

    private bool lsBookValid()
    {
        return pages > 0;
    }

    public string ReadPage()
    {
        if (!lsBookValid())
        {
            return "Invalid Book. Unable to read";
        }

        else if (pagesRead >= pages)
        {
            return "This book has been read entirely.";
        }

        else if (pagesRead == pages - 1)
        {
            pagesRead++;
            return $"You read one page out of a total {pages} page(s), completing the entire book.";
        }
        else
        {
            pagesRead++;
            int remainingPages = pages - pagesRead;
            return $"You read one page and have {remainingPages} left to read out of a total of {pages}.";
        }
    }

    public string ReadPage(int pagesToRead)
    {
        if (!lsBookValid())
        {
            return "Invalid Book. Unable to read";
        }
         else if (pagesToRead <= 0 || pagesToRead > pages - pagesRead)
        {
            return "Invalid number of pages to read";
        }
        else
        {
            pagesToRead += pagesToRead;

            if (pagesToRead >= pages)
            {
                return "You read this book entirely";
            }
            else
            {
                int remainingPages = pages - pagesRead;
                return $"You read {pagesToRead} page(s) and have {remainingPages} page(s) left to read out of {pages}";
            }
        }
    }

}