# 🗄️ TFL Shopping E-Commerce Database Schema

## 📌 Purpose

This database supports a **complete E-Commerce system**, including:

* Product & category management
* User accounts
* Cart & order processing
* Payments & shipping
* Inventory & tracking
* Discounts, loyalty, and subscriptions

---

# 📊 Tables Documentation (Purpose + Structure)

---

## 🗂️ Categories

**Purpose:** Stores product categories.

| Column | Type        | Description   |
| ------ | ----------- | ------------- |
| id     | INT (PK)    | Category ID   |
| name   | VARCHAR(50) | Category name |

---

## 📦 Products

**Purpose:** Stores product details.

| Column        | Type          | Description  |
| ------------- | ------------- | ------------ |
| id            | INT (PK, AI)  | Product ID   |
| name          | VARCHAR(100)  | Product name |
| description   | TEXT          | Description  |
| price         | DECIMAL(10,2) | Price        |
| stock         | INT           | Stock        |
| image         | VARCHAR(255)  | Image        |
| category_id   | INT (FK)      | Category     |
| created_at    | TIMESTAMP     | Created time |
| last_modified | TIMESTAMP     | Updated time |

---

## 👤 Users

**Purpose:** Stores user information.

| Column     | Type         | Description  |
| ---------- | ------------ | ------------ |
| id         | INT (PK, AI) | User ID      |
| username   | VARCHAR(50)  | Username     |
| password   | VARCHAR(255) | Password     |
| email      | VARCHAR(100) | Email        |
| address    | VARCHAR(255) | Address      |
| created_at | TIMESTAMP    | Created time |

---

## 🧩 CategoryProduct

**Purpose:** Maps products with categories and subcategories.

| Column         | Type          | Description |
| -------------- | ------------- | ----------- |
| id             | INT (PK)      | Product ID  |
| name           | VARCHAR(50)   | Name        |
| description    | VARCHAR(1000) | Description |
| price          | INT           | Price       |
| stock          | INT           | Stock       |
| image          | VARCHAR(255)  | Image       |
| category_id    | INT (FK)      | Category    |
| subcategory_id | INT (FK)      | Subcategory |

---

# 🛒 Cart Management

---

## 🛍️ Cart

**Purpose:** Stores user cart.

| Column      | Type      | Description  |
| ----------- | --------- | ------------ |
| cart_id     | INT (PK)  | Cart ID      |
| customer_id | INT (FK)  | User         |
| created_at  | TIMESTAMP | Created time |

---

## 🧾 Cart Items

**Purpose:** Stores items inside cart.

| Column       | Type         | Description |
| ------------ | ------------ | ----------- |
| cart_item_id | INT (PK)     | ID          |
| cart_id      | INT (FK)     | Cart        |
| product_id   | INT (FK)     | Product     |
| quantity     | INT          | Quantity    |
| ItemImage    | VARCHAR(255) | Image       |

---

# 📦 Order Management

---

## 📑 Orders

**Purpose:** Stores order details.

| Column              | Type        | Description |
| ------------------- | ----------- | ----------- |
| id                  | INT (PK)    | Order ID    |
| customer_id         | INT (FK)    | User        |
| order_date          | DATE        | Date        |
| shipping_address_id | INT (FK)    | Address     |
| total_amount        | DECIMAL     | Total       |
| shipping_date       | DATE        | Shipping    |
| status              | VARCHAR(50) | Status      |

---

## 📦 Order Items

**Purpose:** Stores items of orders.

| Column   | Type     | Description |
| -------- | -------- | ----------- |
| id       | INT (PK) | ID          |
| order_id | INT (FK) | Order       |
| item_id  | INT (FK) | Product     |
| quantity | INT      | Quantity    |

---

## 📊 Order Status

**Purpose:** Tracks order status history.

| Column      | Type     | Description |
| ----------- | -------- | ----------- |
| order_id    | INT (FK) | Order       |
| status      | ENUM     | Status      |
| status_date | DATE     | Date        |

---

# 🚚 Shipping

---

## 🏠 Shipping Addresses

**Purpose:** Stores delivery addresses.

| Column              | Type         | Description |
| ------------------- | ------------ | ----------- |
| shipping_address_id | INT (PK)     | ID          |
| address             | VARCHAR(255) | Address     |
| city                | VARCHAR(50)  | City        |
| state               | VARCHAR(50)  | State       |
| zip_code            | VARCHAR(10)  | Zip         |
| country             | VARCHAR(50)  | Country     |
| user_id             | INT (FK)     | User        |

---

## 🚚 Shipments

**Purpose:** Tracks shipment.

| Column             | Type         | Description |
| ------------------ | ------------ | ----------- |
| shipment_id        | INT (PK)     | ID          |
| order_id           | INT (FK)     | Order       |
| shipping_method_id | INT (FK)     | Method      |
| shipment_date      | TIMESTAMP    | Date        |
| tracking_number    | VARCHAR(100) | Tracking    |
| status             | ENUM         | Status      |

---

## 🚛 Shipping Methods

**Purpose:** Defines shipping options.

| Column             | Type          | Description |
| ------------------ | ------------- | ----------- |
| shipping_method_id | INT (PK)      | ID          |
| method_name        | VARCHAR(100)  | Name        |
| description        | TEXT          | Details     |
| cost               | DECIMAL(10,2) | Cost        |

---

# 💳 Payments

---

## 💰 Payments

**Purpose:** Stores payments.

| Column         | Type      | Description |
| -------------- | --------- | ----------- |
| payment_id     | INT (PK)  | ID          |
| order_id       | INT (FK)  | Order       |
| payment_date   | TIMESTAMP | Date        |
| payment_amount | DECIMAL   | Amount      |
| payment_method | ENUM      | Method      |
| payment_status | ENUM      | Status      |

---

## 🧾 Billing Adjustments

**Purpose:** Handles billing corrections.

| Column            | Type         | Description |
| ----------------- | ------------ | ----------- |
| adjustment_id     | INT (PK)     | ID          |
| user_id           | INT (FK)     | User        |
| adjustment_amount | DECIMAL      | Amount      |
| reason            | VARCHAR(255) | Reason      |

---

# 📦 Inventory

---

## 📊 Inventory

**Purpose:** Tracks stock.

| Column         | Type     | Description |
| -------------- | -------- | ----------- |
| inventory_id   | INT (PK) | ID          |
| product_id     | INT (FK) | Product     |
| stock_quantity | INT      | Stock       |

---

## 📜 Product Audit

**Purpose:** Logs stock changes.

| Column             | Type     | Description |
| ------------------ | -------- | ----------- |
| audit_id           | INT (PK) | ID          |
| inventory_id       | INT      | Inventory   |
| action_type        | ENUM     | Action      |
| old_stock_quantity | INT      | Old         |
| new_stock_quantity | INT      | New         |

---

## 💸 Price Changes

**Purpose:** Tracks price updates.

| Column     | Type     | Description |
| ---------- | -------- | ----------- |
| change_id  | INT (PK) | ID          |
| product_id | INT (FK) | Product     |
| old_price  | DECIMAL  | Old         |
| new_price  | DECIMAL  | New         |

---

# 🎁 Discounts & Loyalty

---

## 🎟️ Discount Codes

**Purpose:** Stores discount offers.

| Column              | Type             | Description |
| ------------------- | ---------------- | ----------- |
| code                | VARCHAR(50) (PK) | Code        |
| discount_percentage | DECIMAL          | Discount    |
| start_date          | DATE             | Start       |
| end_date            | DATE             | End         |

---

## 🧾 Order Discounts

**Purpose:** Applies discounts to orders.

| Column        | Type        | Description |
| ------------- | ----------- | ----------- |
| order_id      | INT (FK)    | Order       |
| discount_code | VARCHAR(50) | Code        |

---

## 🎯 Loyalty Redemptions

**Purpose:** Tracks reward usage.

| Column          | Type     | Description |
| --------------- | -------- | ----------- |
| redemption_id   | INT (PK) | ID          |
| user_id         | INT (FK) | User        |
| points_redeemed | INT      | Points      |
| status          | ENUM     | Status      |

---

# 🔄 Returns & Subscriptions

---

## 🔁 Returns

**Purpose:** Manages returns.

| Column     | Type     | Description |
| ---------- | -------- | ----------- |
| return_id  | INT (PK) | ID          |
| order_id   | INT (FK) | Order       |
| product_id | INT (FK) | Product     |
| status     | ENUM     | Status      |

---

## 🔔 Subscriptions

**Purpose:** Stores subscriptions.

| Column          | Type        | Description |
| --------------- | ----------- | ----------- |
| subscription_id | INT (PK)    | ID          |
| user_id         | INT (FK)    | User        |
| plan            | VARCHAR(50) | Plan        |
| status          | ENUM        | Status      |

---

# 📁 Extra Tables

---

## 📦 Purchase Orders

**Purpose:** Tracks restocking.

| Column     | Type     | Description |
| ---------- | -------- | ----------- |
| order_id   | INT (PK) | ID          |
| product_id | INT (FK) | Product     |
| quantity   | INT      | Quantity    |

---

## 🗃️ Archived Orders

**Purpose:** Stores old orders.

| Column       | Type     | Description |
| ------------ | -------- | ----------- |
| order_id     | INT (PK) | ID          |
| customer_id  | INT      | User        |
| total_amount | DECIMAL  | Total       |

---

## 📅 Closed Dates

**Purpose:** Stores special dates.

| Column       | Type         | Description |
| ------------ | ------------ | ----------- |
| close_id     | INT (PK)     | ID          |
| closed_dates | DATETIME     | Date        |
| events       | VARCHAR(255) | Event       |

---

# ✅ Conclusion

This schema provides a **complete enterprise-level eCommerce backend**, covering:

✔ Products & inventory
✔ Orders & payments
✔ Shipping & fulfillment
✔ Discounts & loyalty
✔ Returns & subscriptions

---
