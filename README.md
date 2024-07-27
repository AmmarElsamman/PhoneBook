# Flashcards

Console based CRUD application Implementing a simple phone book.
Developed using C# and MS Server.

# Given Requirements:

- [x] This is an application where you should record contacts with their phone numbers.
- [x] Users should be able to Add, Delete, Update and Read from a database, using the console. 
- [x] You need to use Entity Framework 
- [x] Your code should contain a base Contact class
- [x] You should validate e-mails and phone numbers and let the user know what formats are expected
- [x] You should use Code-First Approach, which means EF will create the database schema for you.
- [x] Expand the app by creating categories of contacts

# Features

* SQL Server database connection

	- Used code-first approach to implement tables 

* A console based UI menu used Spectre.Console Package
  - ![main menu](https://github.com/user-attachments/assets/5634b27f-e04c-4369-b2b6-37907c841688)


* Add menu to add new contacts
  - Each Option calls independent method which handles the database requests
  - Added a droplist to choose contact relation
  - ![Add menu](https://github.com/user-attachments/assets/f9f78163-e8a2-459e-b93a-347397184a8c)

* Delete menu to choose which contact to delete
  - ![Delete Menu](https://github.com/user-attachments/assets/a0f9065c-6554-4fa7-bb3e-2d143f194b4c)

* View menu to view contacts data
  - ![View Menu](https://github.com/user-attachments/assets/54dc74d8-11a4-4eae-9f8a-e1c699dd78a0)


 
