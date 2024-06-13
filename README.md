## Hasta Takip Sistemi Projesi

### Overview

This repository contains the final project for the Object-Oriented Programming course. The purpose of this project is to enhance my proficiency in C#, improve my project planning skills, and develop my algorithmic thinking abilities. I aimed to push my limits as much as possible with this project.

### Features

- **Forms:** The application includes 7 forms (Login, Main Screen, Doctor Operations, Patient Operations, User Operations, Payment Operations, and a surprise form).
- **Database Integration:** Utilizes SQL Server Database for user information queries.
- **Login Attempts Logging:** Records both successful and unsuccessful login attempts of registered users.
- **User Authorization:** Classifies user permissions based on user type and restricts functionalities accordingly.
- **User Management:** Allows adding, deleting, and updating users with Doctor, Patient, and Secretary roles.
- **Patient Management:** Enables adding, updating, and deleting patient records.
- **Medical Records:** Allows adding tests and diagnoses to patient records.
- **Payment Processing:** Facilitates payments through the payment screen if there is a payment associated with the patient.

### Technologies Used

- **Programming Language:** C#
- **Database:** SQL Server
- **Platform:** Windows Forms Application

### Installation

To run this application locally, follow these steps:

1. **Clone the repository:**
    ```bash
    git clone https://github.com/EsseEstDeus/Hasta-Takip-Sistemi-Projesi.git
    ```

2. **Open the project in Visual Studio:**
    - Launch Visual Studio.
    - Open the solution file (.sln) located in the cloned repository.

3. **Restore NuGet packages:**
    - In Visual Studio, go to `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.
    - Run the command:
      ```powershell
      Update-Package -reinstall
      ```

4. **Set up the database:**
    - Ensure SQL Server is installed and running.
    - Execute the SQL scripts provided in the `/database` directory to set up the database.

5. **Configure the connection string:**
    - Update the connection string named `"BaglantiBilgileri"` in the forms with your SQL Server credentials.

6. **Build and run the project:**
    - Press `F5` or go to `Debug` -> `Start Debugging`.

### Usage

- Navigate through the application using the menu and buttons.
- Enter data into the provided fields and interact with the various UI components to utilize the features of the application.

### Contributions

I worked on this project with @salanderm.
In this project, I worked on both the SQL Server Database and the Forms App. I implemented features across all aspects of the project.

### License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

### Contact

If you have any questions or suggestions, feel free to contact me at [burakalkan1289@gmail.com].
