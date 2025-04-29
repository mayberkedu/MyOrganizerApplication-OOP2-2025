# MyOrganizerApplication

## Overview

This is a Windows Forms-based personal organizer application developed in C#. The application is designed to be used by multiple users and includes the following modules:

- **User Management**: Manage users with different roles (Admin, User, Part-Time User).
- **Phonebook**: Store and manage contacts with detailed information.
- **Notes**: Create and manage personal notes.
- **Personal Information**: View and edit user profiles, including a photo upload feature.
- **Reminders**: Set and manage reminders with specific dates and times.
- **Salary Calculator**: Calculate and store minimum salary information based on specific criteria.

## Features

### User Management
![administration](https://github.com/user-attachments/assets/dbae1d17-7f5a-432d-9fc3-084b7f641b27)

- The first user to register becomes the system administrator.
- Admins can change the role of other users.
- Supports three user roles: Admin, User, and Part-Time User.
- Admin users can manage the user list, add new users, update or delete users, and download user data.

### Phonebook
![phonebook](https://github.com/user-attachments/assets/ab8eed1b-e0f2-4340-8289-40fdcc717192)

- Users can add, update, delete, and list contacts.
- Data is stored in a `phonebook.csv` file.
- Fields include Name, Surname, Phone Number, Address, Description, and E-mail.
- The phone number is formatted as (555) 555-5555.
- E-mail field validation using regular expressions.

### Notes
![notebook](https://github.com/user-attachments/assets/2808fc2f-246b-41cb-8792-f55a5a7b112a)

- Simple note-taking module where users can add, update, delete, and list notes.
- Data is stored in a `notes.csv` file.

### Personal Information
![home page](https://github.com/user-attachments/assets/db5f42c6-a26a-427f-9308-3bd02127d09e)

- Users can view and update their profile information.
- Profile fields include Name, Surname, Username, Phone Number, Address, E-mail, Password, and Photo.
- The photo is stored in the CSV file as a base64 string.
- Supports undo (CTRL-Z) and redo (CTRL-Y) operations for field changes.

### Reminders
![reminder](https://github.com/user-attachments/assets/4c5d66db-ed6c-449e-b7d2-8ee5a0e17d0d)

- Users can create, update, delete, and list reminders.
- Reminders are categorized as either Meetings or Tasks.
- Each reminder includes a Date, Time, Summary, and Description.
- The reminder summary is displayed on the active window header, and the window shakes for two seconds when a reminder is triggered.

### Salary Calculator
![salary calculator](https://github.com/user-attachments/assets/43c4e848-560a-416c-b45e-91757320ba8b)

- Calculates the user's minimum salary based on their education, experience, family status, and foreign language skills.
- The salary for part-time users is automatically reduced by 50%.
- The calculated salary is displayed on the user profile page and stored in the user's data.

## Usage
![login](https://github.com/user-attachments/assets/93d723eb-4dad-474f-b342-59aff15e4376)

1. **Login**: Users must log in using their username and password. The first registered user will have admin privileges.
2. **Navigation**: The application provides a main menu for accessing different modules such as the Phonebook, Notebook, Reminder, Salary Calculator, and User Management (for admins).
3. **User Management**: Admin users can access the user management screen to manage other users' accounts.
4. **Phonebook**: Add, update, or delete contacts from the phonebook. Contacts can be searched by name or surname.
5. **Notes**: Use the notebook module to add, update, or delete personal notes.
6. **Reminders**: Set reminders for meetings or tasks, and manage them using the reminder module.
7. **Salary Calculation**: Use the salary calculator to determine the minimum salary based on your profile's specific parameters.

## Files

- `contacts.csv`: Stores phonebook contact information.
- `notebookdata.csv`: Stores notes created by the user.
- `applicationdatabase.csv`: Stores user information including their role and profile details.
- `reminder.csv`: Stores reminder data for each user.

## Setup and Installation

1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Build the project to restore any missing NuGet packages.
4. Run the application from Visual Studio.


