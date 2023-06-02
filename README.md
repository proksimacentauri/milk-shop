# milk-shop
milk shop practice
# Milk Products E-commerce Site

This project is an e-commerce website for milk products. The backend API is built with .NET Core and Entity Framework, and the frontend is built with React.

## Prerequisites

- .NET Core SDK 3.1 or later
- A SQL Server instance for the database

## Backend Setup

1. Navigate to the server directory:

   ```sh
   cd server
Restore the .NET dependencies:

 ```sh
   cd server
  dotnet restore
  ```
  
 Provide your connection string by using usersecrets:

 ```sh 
  dotnet user-secrets set "ConnectionStrings:YourConnectionString" "connectionstringHere123"
  ```
Apply the database migrations to set up the database schema:

 ```sh
   cd server
dotnet ef database update
  ```
Run the backend server:
  ```sh
Copy code
dotnet run
  ```
The API will be available at http://localhost:5163.

Frontend Setup
Install the necessary dependencies:

```sh
Copy code
npm install
```
Run the frontend development server:
```sh
Copy code
npm run dev
```
The frontend will be available at http://localhost:5173.


Features
- Product Browsing: Users can view all available milk products and see products in detail.
- Pagination: There is basic pagination that is stored in the search parameter in the url.
- Filtering: Basic filtering for types of milk that is stored in the search parameter in the url.
- Search: Search that searches for certain milk product of your need.
- Shopping Cart: Users can add products to their cart and delete them.
- Checkout: Users can see the cartitems in the checkout.
- Order Placement: Users can place orders that gets stored in the database.

API Endpoints
- /api/products: Get all products.
- /api/Products/category: Get all categories for products that exist.
- /api/Products/{id}: Get, update quantity for a certain product.
- /api/Carts: Create a new cart
- /api/Carts/{cartId}: Get certain cart and its items or post new cart items to the cart.
- /api/Carts/{cartId}/Order: Places an order.
- /api/Carts/{cartId}/Item/{itemId}: deletes certain cartitem from cart.
