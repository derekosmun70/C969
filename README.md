# Scheduling Application

## Overview

This C# desktop application, developed for the C969 course, is a scheduling tool designed for managing customer records and appointments in a business environment, such as consulting or service-based organizations. It enables users to securely log in, manage customer data, schedule appointments, and generate reports while enforcing business rules like operating hours and data validation. The app connects to a database to store and retrieve data, incorporating robust error handling and time zone awareness for a seamless user experience.

## Features

### User Authentication and Login
- **Login Form**: Verifies username and password against stored credentials.
- **Location Detection**: Identifies the user's location upon login.
- **Multi-Language Support**: Translates login and error messages (e.g., "The username and password do not match.") into English and one additional language.
- **Login History**: Logs each login attempt's timestamp and username in `Login_History.txt`, appending new entries.

### Customer Management
- **CRUD Operations**: Add, update, and delete customer records.
- **Validation**:
  - Records require name, address, and phone number fields.
  - Fields are trimmed and must be non-empty.
  - Phone numbers allow only digits and dashes.
- **Exception Handling**: Implemented for add, update, and delete operations.

### Appointment Management
- **CRUD Operations**: Add, update, and delete appointments, linking them to customers and capturing appointment types.
- **Validation**:
  - Appointments must be scheduled between 9:00 a.m. and 5:00 p.m., Monday–Friday, Eastern Standard Time (EST).
  - Prevents overlapping appointments.
- **Exception Handling**: Covers add, update, and delete operations.
- **Calendar View**: Displays appointments for a selected day via a monthly calendar.
- **Time Zone Support**: Adjusts appointment times based on user time zones and daylight saving time.
- **Alerts**: Notifies users of appointments starting within 15 minutes upon login.

### Reporting
Using collection classes and lambda expressions, the app generates:
- **Appointment Types by Month**: Counts appointment types per month.
- **User Schedules**: Shows each user's schedule.
- **Custom Report**: An additional report (e.g., customer appointment history).

## Purpose
This application streamlines customer and appointment management for businesses operating in EST. It ensures data integrity, supports international users through localization and time zone adjustments, and provides actionable insights via reports. It's ideal for coordinating schedules across multiple users while maintaining security and audit logs.

## Requirements
- **Environment**: Visual Studio with .NET framework.
- **Database**: Requires a configured backend database (connection setup needed).
- **Dependencies**: Standard .NET libraries for forms, data handling, and time zone management.

## Installation
1. Unzip the exported project file.
2. Open the solution in Visual Studio.
3. Configure the database connection (e.g., update connection strings).
4. Build and run the application.

## Usage
1. Log in with valid credentials.
2. Manage customer records or appointments via dedicated sections.
3. Use the calendar to view or schedule appointments.
4. Generate reports from the report menu.
5. Alerts and login logs are handled automatically.

## Project Structure
- Developed in C# using Visual Studio.
- Exported as a ZIP file for submission.
- Includes comprehensive error handling and validation to meet business requirements.

## Notes
- Ensure the database is properly set up before running.
- The app assumes a standard EST business schedule for validation.
- Login history is stored in `Login_History.txt` in the application directory.

This project demonstrates robust scheduling functionality, professional code organization, and adherence to business constraints, making it a practical tool for real-world applications.
