# Cloud Products Application

## Overview

This application allows customers to view a list of cloud products with their descriptions and prices. It consists of a front-end built with React.js and a back-end built with ASP.NET Core Web API (C#). The application fetches product data from an API and displays it with a 20% markup on the prices.

## Features

- View a list of cloud products.
- Display product descriptions and prices with a 20% markup.

## Technologies

- Front-End: React.js
- Back-End: ASP.NET Core Web API
- API: Vendor API at http://alltheclouds.com.au

## Prerequisites

- Node.js
- .NET SDK

## Getting Started

### Front-End Setup

1. **Clone the repository:**

   bash
   git clone https://github.com/your-username/cloud-products-app.git
   cd cloud-products-app
   
2. **Navigate to the client directory and install dependencies:**

  bash
  cd client
  npm install

3. **Run the React application:**

  bash
  npm start

The application will run on http://localhost:3000.

### Back-End Setup

1. **Navigate to the server directory:**

  bash
  cd ../server

2. **Restore .NET dependencies:**

  bash
  dotnet restore

3. **Run the ASP.NET Core application:**

  bash
  dotnet run
  
The API will run on http://localhost:5051.

## Configuration
Ensure the front-end is set up to fetch data from the correct back-end API endpoint. The fetch URL in ProductList.js should point to http://localhost:5000/api/products.


## API Endpoints
GET /api/products
Fetches the list of products with descriptions and prices (including 20% markup).

Example Response
json
[
    {
        "id": 1,
        "name": "Product A",
        "description": "Description A",
        "price": 120.00
    },
    {
        "id": 2,
        "name": "Product B",
        "description": "Description B",
        "price": 180.00
    }
]
## Development
### Front-End
To add new features or make changes, edit the components in the client/src/components directory.

### Back-End
To add new endpoints or modify existing ones, edit the controllers and models in the server directory.

## Deployment
### Front-End
Build the React application for production:

  bash
  npm run build

### Back-End
Publish the ASP.NET Core application:

  bash
  dotnet publish -c Release

## License
This project is licensed under the MIT License.
