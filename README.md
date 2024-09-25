# VetCare Backend
### Veterinary Management System

## Description:
VetCare is a management system for veterinary clinics, designed to facilitate the administration of appointments, pets, and related services. This backend is built with ASP.NET Core and provides a RESTful API to interact with the database.

## Technologies Used
- **Language:** C#
- **Framework:** ASP.NET Core
- **Database:** MySQL
- **Authentication:** JWT (JSON Web Tokens)
- **ORM:** Entity Framework Core
- **Email Services:** STPM GMAIL
- **Others:** BCrypt, IMGUR, REMOVEBG

## Installation
### 1. Clone the repository:
git clone https://github.com/Jhon-Develop/VetCare_BackEnd.git
cd VetCare_BackEnd

### 2. Configure the .env file at the root of the project with the following variables:
**DB_HOST=** bisjyp95m3bxm1kyeq4g-mysql.services.clever-cloud.com<br>
**DB_PORT=** 3306<br>
**DB_DATABASE=** bisjyp95m3bxm1kyeq4g<br>
**DB_USERNAME=** urgf9rpffgzhrije<br>
**DB_PASSWORD=** P0vs0vDcsKBVCBOVYqg7d<br>
**JWTKEY=** 4cc2e6340aaa321c5f06c570160ea4cdfff68bc512c9b806c418f378da025c2<br>
**EMAIL=** vetcarepets2024@gmail.com<br>
**PASSWORD=** gfnekcdfltsipcad<br>
**APIKEY_REMOVEBG=** 8sXu8UQBfPxMXbMP15C8eg6j

Replace with the respective variable values.

### 3. Restore NuGet packages:
dotnet restore

### 4. Run migrations to create the database:
dotnet ef database update

### 5. Start the server:
dotnet run

## Usage
The API is available at **https://vetcare-backend.azurewebsites.net**. You can interact with it using tools like Postman or Swagger.

### Example request to create an appointment
POST /api/v1/appointments/create
<code>
{
    "UserId": 1,
    "PetId": 2,
    "AppointmentTypeId": 1,
    "EndDate": "2024-09-30T15:00:00Z",
    "Description": "General consultation"
}
</code>

### Example response for scheduling a new appointment
<code>
{
  "id": 1,
  "petId": 2,
  "startDate": "2024-09-30T15:00:00Z",
  "endDate": "2024-09-30T16:00:00Z",
  "description": "General consultation",
  "available": true
}
</code>

## API
### Endpoints:

## Appointment:

### Create Appointment
**URL:**  /api/v1/appointments/create  
**Method:**  POST  
**Description:**  Creates a new appointment.  
**Response:** Details of the created appointment.  

### Get All Appointments
**URL:**  /api/v1/appointments/getall  
**Method:**  GET  
**Description:**  Retrieves all appointments with pagination.  
**Response:** List of appointments.  

### Get Appointment by ID
**URL:**  /api/v1/appointments/getbyid/{id}  
**Method:**  GET  
**Description:**  Retrieves an appointment by its ID.  
**Response:** Details of the appointment.  

### Get Appointments by Keyword
**URL:**  /api/v1/appointments/getbykeyword  
**Method:**  GET  
**Description:**  Retrieves appointments that match the specified keyword in their description.  
**Response:** List of matching appointments.  

### Get Appointments by Pet ID
**URL:**  /api/v1/appointments/getbypetid/{petId}  
**Method:**  GET  
**Description:**  Retrieves appointments based on the pet's ID.  
**Response:** List of appointments associated with the pet.  

### Update Appointment
**URL:**  /api/v1/appointments/updateAppointment/{id}  
**Method:**  PUT  
**Description:**  Updates an existing appointment by ID.  
**Response:** Details of the updated appointment.  

### Delete Appointment
**URL:**  /api/v1/appointments/delete/{id}  
**Method:**  DELETE  
**Description:**  Deletes an existing appointment by ID.  
**Response:** Confirmation message of deletion.  


## AppointmentTypes:

### Create Appointment Type
**URL:**  /api/v1/appointmentTypes/create  
**Method:**  POST  
**Description:**  Creates a new appointment type.  
**Response:** Details of the created appointment type.  

### Get All Appointment Types
**URL:**  /api/v1/appointmentTypes/getall  
**Method:**  GET  
**Description:**  Retrieves all appointment types.  
**Response:** List of appointment types.  

### Get Appointment Type by ID
**URL:**  /api/v1/appointmentTypes/getbyid/{id}  
**Method:**  GET  
**Description:**  Retrieves an appointment type by its ID.  
**Response:** Details of the appointment type.  

### Get Appointment Types by Keyword
**URL:**  /api/v1/appointmentTypes/getbykeyword  
**Method:**  GET  
**Description:**  Retrieves appointment types that match the keyword.  
**Response:** List of matching appointment types.  

### Update Appointment Type Name
**URL:**  /api/v1/appointmentTypes/updateName/{id}  
**Method:**  PATCH  
**Description:**  Updates the name of an appointment type by ID.  
**Response:** Details of the updated appointment type.  

### Delete Appointment Type
**URL:**  /api/v1/appointmentTypes/delete/{id}  
**Method:**  DELETE  
**Description:**  Deletes an existing appointment type by ID.  
**Response:** Confirmation message of deletion.  


## Auth:

### User Registration
**URL:**  /api/Auth/Register  
**Method:**  POST  
**Description:**  Registers a new user.  
**Response:** Details of the registered user.  

### Login
**URL:**  /api/Auth/Login  
**Method:**  POST  
**Description:**  Logs in and generates a JWT token.  
**Response:** Access token.  

### Request Password Reset
**URL:**  /api/Auth/RequestPasswordReset  
**Method:**  POST  
**Description:**  Requests a password reset by sending a link via email.  
**Response:** Confirmation message.  

### Reset Password
**URL:**  /api/Auth/ResetPassword  
**Method:**  POST  
**Description:**  Resets the user's password using a reset token.  
**Response:** Confirmation message of password change.  


## DocumentType:

### Add New Document Type
**URL:**  /api/v1/DocumentTypes  
**Method:**  POST  
**Description:**  Adds a new document type.  
**Response:** Details of the created document type.  

### Show All Document Types
**URL:**  /api/v1/DocumentTypes  
**Method:**  GET  
**Description:**  Shows all document types.  
**Response:** List of document types.  

### Update Document Type
**URL:**  /api/v1/DocumentTypes/{id}  
**Method:**  PUT  
**Description:**  Updates a document type.  
**Response:** Details of the updated document type.  

### Delete Document Type
**URL:**  /api/v1/DocumentTypes/{id}  
**Method:**  DELETE  
**Description:**  Deletes a document type.  
**Response:** Confirmation message of deletion.  


## Pet:

### Create Pet
**URL:**  /api/v1/Pet/CreatePet  
**Method:**  POST  
**Description:**  Creates a new pet.  
**Response:** Details of the created pet.  

### Show All Pets
**URL:**  /api/v1/Pet/allPets  
**Method:**  GET  
**Description:**  Shows all registered pets.  
**Response:** List of pets.  

### Show Paginated Pets
**URL:**  /api/v1/Pet/allPaginatedPets  
**Method:**  GET  
**Description:**  Shows pets with pagination.  
**Response:** Paginated list of pets.  

### Search Pet by ID
**URL:**  /api/v1/Pet/petById/{id}  
**Method:**  GET  
**Description:**  Searches for a pet by its ID.  
**Response:** Details of the pet.  

### Search Pet by Owner ID
**URL:**  /api/v1/Pet/petByUserId/{id}  
**Method:**  GET  
**Description:**  Searches for a pet by its owner's ID.  
**Response:** List of pets associated with the owner.  

### Update Pet
**URL:**  /api/v1/Pet/UpdatePet/{id}  
**Method:**  PUT  
**Description:**  Updates a pet.  
**Response:** Details of the updated pet.  

### Delete Pet
**URL:**  /api/v1/Pet/DeletePet/{id}  
**Method:**  DELETE  
**Description:**  Deletes a pet.  
**Response:** Confirmation message of deletion.  


## Roles:

### Create New Role
**URL:**  /api/v1/roles/create  
**Method:**  POST  
**Description:**  Creates a new role.  
**Response:** Details of the created role.  

### Get All Roles
**URL:**  /api/v1/roles/getall  
**Method:**  GET  
**Description:**  Gets all roles.  
**Response:** List of roles.  

### Get Role by ID
**URL:**  /api/v1/roles/getbyid/{id}  
**Method:**  GET  
**Description:**  Gets a role by its ID.  
**Response:** Details of the role.  

### Get Roles by Keyword
**URL:**  /api/v1/roles/getbykeyword  
**Method:**  GET  
**Description:**  Gets roles that match the keyword.  
**Response:** List of matching roles.  

### Update Role Name
**URL:**  /api/v1/roles/updateName/{id}  
**Method:**  PATCH  
**Description:**  Updates the name of a role by ID.  
**Response:** Details of the updated role.  

### Delete Role
**URL:**  /api/v1/roles/delete/{id}  
**Method:**  DELETE  
**Description:**  Deletes an existing role by ID.  
**Response:** Confirmation message of deletion.  


## User:

### Create New User
**URL:**  /api/v1/users/create  
**Method:**  POST  
**Description:**  Creates a new user.  
**Response:** Details of the created user.  

### Get Paginated Users
**URL:**  /api/v1/users  
**Method:**  GET  
**Description:**  Retrieves a paginated list of users.  
**Response:** List of users.  

### Search User by ID
**URL:**  /api/v1/users/{id}  
**Method:**  GET  
**Description:**  Searches for a user by their ID.  
**Response:** Details of the user.  

### Update User
**URL:**  /api/v1/users/{id}  
**Method:**  PUT  
**Description:**  Updates a user.  
**Response:** Details of the updated user.  

### Search User by Name
**URL:**  /api/v1/users/findByName/{name}  
**Method:**  GET  
**Description:**  Searches for a user by their name.  
**Response:** Details of the user.  

### Search User by Initial
**URL:**  /api/v1/users/FindByInitial/{initial}  
**Method:**  GET  
**Description:**  Searches for a user by their initial.  
**Response:** Details of the user.  

### Search User by Keyword
**URL:**  /api/v1/users/getbykeyword  
**Method:**  GET  
**Description:**  Searches for a user by keywords.  
**Response:** List of matching users.  

---------------------------------------------------------------------------------------------------------


# VetCare
## Because your pet is a member of your family!

VetCare was created to address the need to prevent pets, especially dogs, from being abandoned on the streets due to the high costs associated with their care. Research shows that 40% of Colombian families have some kind of pet in their home. Additionally, there is a significant number of stray dogs in need of assistance. Recent studies from La Salle University reveal that for every 100 dogs living with a family in Bogotá, Colombia, there are 38 stray dogs. And what about cats or other pets? This number can rapidly increase. But what is the reason behind so many dogs being left on the streets?
For many people, when they realize how expensive it is to care for a pet, they simply decide to abandon them, without considering how painful this can be for the animal. On top of that, many of these stray dogs are not neutered, leading to the overpopulation of street dogs.
VetCare will offer affordable prices for customers, helping Colombian citizens save hundreds of thousands of pesos in pet care costs, while also contributing to the control and improvement of the well-being of abandoned pets, particularly dogs.
VetCare is the solution for Colombian pet owners who feel forced to abandon their pets due to financial constraints, especially given the high costs of pet care in the country. Moreover, VetCare is dedicated to rescuing pets that have been abandoned and providing them with completely free treatment for any health issues they are facing.

## CHOSEN THEME
The chosen theme for this project  can be E-commerce & Health 

## OBJECTIVES
- Affordable Veterinary Care: Provide affordable medical care to pets, helping Colombian pet owners avoid abandonment due to high veterinary costs.
- Pet Rescue and Treatment: Rescue abandoned pets and offer them free medical care to improve their health and quality of life.
- User-Friendly Platform: Develop a user-centric platform that allows pet owners to easily manage their pets' information and schedule veterinary appointments.
- Health & E-Commerce Integration: Combine healthcare services with e-commerce functionality for booking appointments and purchasing related products or services online.
- Increase Awareness: Raise awareness about responsible pet ownership and the importance of neutering to control overpopulation.

## PROJECT SCOPE
VetCare will provide a digital platform for pet owners to manage their pets and schedule appointments with veterinarians. It will also serve as a tool for rescuing and treating stray pets. The scope includes:

- User Profile Management: Registered users can update their personal details, manage pet profiles, and view scheduled appointments.
- Pet Management: Users can add, update, or remove pets from their profile, providing detailed information such as breed, age, and medical history.
- Appointment Booking: Users can book veterinary appointments for their pets by selecting available time slots, providing information on the reason for the appointment, and receiving confirmation.
- Pet Rescue: Integration of a rescue feature to track and provide free treatment to stray pets.


# TEAM MEMBERS

1. **Mariana Perez Serna**
**GitHub:** mkserna
**Email:** mperezserna8@gmail.com
**LinkedIn:** https://www.linkedin.com/in/mariana-p%C3%A9rez-serna-829b4b200/

2. **Juan Diego Zuluaga Ramirez**  
**GitHub:** Jzulu22x  
**Email:** Juanzr1015@gmail.com  
**LinkedIn:** https://www.linkedin.com/in/juan-diego-zuluaga-ramirez-337aa12b3  

3. **Juan Jose Zapata**  
**GitHub:** Z4pata  
**Email:** zapata.devs@gmail.com  
**LinkedIn:** https://www.linkedin.com/in/juan-jose-zapata-fernandez-05b4412b9/  

4. **Jhon Edwin Asprilla Guisao**  
**GitHub:** Jhon-Develop  
**Email:** asprillajhon73@gmail.com  
**LinkedIn:** https://www.linkedin.com/in/jhon-asprilla-511534324/  

5. **Oscar Camilo Calle Gil**  
**GitHub:** OscarCalle0  
**Email:** Oscarcalle0@gmail.com  
**LinkedIn:** https://www.linkedin.com/in/oscar-calle-a19b27157/

6. **Leison Mosquera Mosquera**  
**GitHub:** Mosquera131  
**Email:** leison3131@hotmail.com  
**LinkedIn:** https://www.linkedin.com/in/leison-mosquera-27590b135/

## PROJECT MODEL

### DATABASE  MODEL
**Link:** https://drive.google.com/file/d/1FVyihJIJQxC58OSa47B7AgZC5eXzgC6U/view?usp=sharing

### UML CLASS DIAGRAMS
**Link:** https://drive.google.com/file/d/1aU4QSqbaf3VTS3j3sSFACUsAMotne9Ti/view?usp=sharing

### COMPONENT ARCHITECTURE MODE
**Link:** https://drive.google.com/file/d/1dVlBK4IXvNXKH61qZro8hqgrdx0B5pUY/view?usp=sharing

### USE CASES
**Link:** https://drive.google.com/file/d/1gh7MjKY4NmlL0kfs3aFTFnu93Lk42kNM/view?usp=sharing


## USER STORIES

### User Stories N°-1 : User Profile Management
**Title:** As a registered user, I want to be able to manage my profile to keep my information up to date and manage my pets.
**Description:**
- As a registered user,
- I want to be able to access my profile to update my personal information (name, last name, document type, document number, password, phone number and email),
- And manage the pets I have registered, including the ability to add new pets, update existing information and delete pets I no longer have.
**Acceptance Criteria:**
- User can access their profile from the navigation menu.
- The user can update their personal information and save it.
- User can view a list of their pets in their profile.
- The user can add a new pet to the profile, specifying details such as name, species, breed, age, etc.
- The user can edit the information of an existing pet.
- The user can remove a pet from their profile.
- Changes are reflected in real time and persist after refreshing the page.
**Technical tasks:**
- Create or modify the APIs needed to handle user information update and CRUD (Create, Read, Update, Delete) operations on pets.
- Implement views and components in React for profile and pet management, using Tailwind CSS for styling.
- Connect React forms to the backend in C# to process changes.
- Implement validations in the frontend and backend to make sure data is correct and complete before submitting or saving.


### User Story N° - 2 : Requesting Appointments for Pets
**Title:** As a registered user, I want to be able to request appointments for my pets to receive medical care at the veterinarian.
**Description:**
- As a registered user,
- I want to be able to request an appointment for one of my pets,
- To ensure that he/she receives the necessary medical care at the veterinarian.
**Acceptance Criteria:**
- The user can access the appointment section from the navigation menu.
- The user can select one of their registered pets for the appointment.
- The user can select an available date and time for the appointment.
- The user can provide additional details (reason for appointment, symptoms, etc.) when requesting the appointment.
- The system must confirm the availability of the appointment before finalizing the request.
- The user receives a confirmation of the appointment after the appointment has been requested.
- The user can see a summary of their scheduled appointments.
**Technical tasks:**
- Create or modify APIs needed to manage appointment request and check availability.
- Implement views and components in React for appointment management, including pet selection, dates and times.
- Connect React forms to the backend in C# to process appointment requests.
- Implement a calendar or date picker that displays available options for appointments.
- Implement validations in the frontend and backend to ensure that the requested appointments are valid and available.


## Functional Requirements

### 1. User Profile Management:
   - Registered users must be able to access and update their personal information, such as name, document type and number, password, phone number, and email.
   - Users can manage their registered pets by adding, updating, or deleting pet information.
   - Changes to profile information must be reflected in real-time and persist after the page is refreshed.

### 2. Pet Management:
   - Users can register new pets, providing details such as name, species, breed, and age.
   - Users can edit information for existing pets.
   - Users can remove pets they no longer own.

### 3. Appointment Request for Pets:
   - Registered users must be able to request veterinary appointments for their pets.
   - Users must select a registered pet, choose an available date and time, and provide additional details (reason for the appointment, symptoms, etc.).
   - The system must confirm the availability of the appointment before finalizing the request.
   - A confirmation of the appointment will be sent to the user.
   - Users can view a summary of their scheduled appointments.

### 4. Appointment Availability Control:
   - The system must allow users to view available dates and times for appointments.
   - Availability must be checked before finalizing the user’s appointment request.

 
 
 ## Non-Functional Requirements

### 1. Security:
   - The platform must ensure the protection of users' personal and sensitive data, such as pet information, through encryption and robust authentication.
   - Validations must be implemented on both the frontend and backend to ensure data is correct and complete.

### 2. Performance:
   - System response times must be fast, especially for high-interaction operations like profile updates and appointment requests.
   - Operations must be processed in real-time to provide a smooth user experience.

### 3. Scalability:
   - The system must be able to support an increasing number of registered users and appointment requests without compromising performance.
   - The architecture must allow for the future integration of new features without impacting existing functionality.

### 4. Usability:
   - The interface must be intuitive and easy to use for all types of users.
   - The design must be responsive, ensuring accessibility across mobile devices and desktops.

### 5. Maintainability:
   - The code must be well-documented and follow best development practices to facilitate future updates and system maintenance.

### 6. Availability:
   - The system must be available 24/7, with minimal downtime for scheduled maintenance tasks.


## URL endpoint documentation:
**Link:** https://vetcare-backend.azurewebsites.net/swagger/index.html


## ClicUp activity manager URL:
**Link:** https://app.clickup.com/9011199549/v/s/90110908493




