	
	# FizzBuzz Web Application

## Description

This is a simple web application developed in C# that processes an array of values and outputs "Fizz" for multiples of 3, "Buzz" for multiples of 5, "FizzBuzz" for multiples of both, and logs each division performed. The project demonstrates principles such as Single Responsibility, Separation of Concerns, and Test Automation (Unit and/or Integration).

## Features

- **FizzBuzz Logic**: Processes numbers and categorizes them as "Fizz", "Buzz", or "FizzBuzz".
- **Logging**: Logs each division operation for transparency.
- **Error Handling**: Handles invalid inputs gracefully.

## Structure

The project consists of the following components:

- **FizzBuzzService**: The core service that processes values and applies the FizzBuzz logic.
- **FizzBuzzResult**: A model to encapsulate the result of the FizzBuzz operation and associated logs.

## Usage

1. Clone the repository:
    ```sh
    git clone https://github.com/prasadtungala/WebApplication1
	
    cd FizzBuzz
    ```

2. Build the project:
    ```sh
    dotnet build
    ```

3. Run the application:
    ```sh
    dotnet run
    ```

4. To test the application, navigate to the appropriate endpoint "/api/fizzbuzz" and submit an array of string values.
