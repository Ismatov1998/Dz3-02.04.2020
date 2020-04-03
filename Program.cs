using System;

namespace MyfirstClass
{
    class Program
    {
        static void Main()
        {
         Book book=new Book();
         book.setinfo("Сестренка", "Кристина Гептинг","Художественное произведение");
         
        
         
        }
    }
    class Book
    {
      Title title1=new Title();
      Author Author1=new Author();
      Content Content1=new Content();
      public void setinfo(string name, string name1,string name2)
      {
       this.title1.title1=name;
       this.Author1.Author1=name1;
       this.Content1.Content1=name2;
      }
       
      
        

    }
    class Title
    {
      public string title1{ set; get; }
      public void show()
      {
       Console.WriteLine($"название книги: {title1}");
      }      

    }
    class Author
    {
      public string Author1{ set; get; }
      public void show()
      {
        Console.WriteLine($"Автор: {Author1}");
      } 

    }
    
    class Content
    {
     public string Content1{ set; get; }
    public void show()
    {
     Console.WriteLine($"Жанр: {Content1}");
    }  

    }
}

