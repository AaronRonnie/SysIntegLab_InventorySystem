# Inventory Management System - Complete How-To Guide

A comprehensive guide for all features including the new Shipping Tab enhancement (v4.0)

---

## 📑 Quick Navigation

- [Getting Started](#getting-started)
- [Inventory Tab](#inventory-tab-guide)
- [Orders Tab](#orders-tab-guide)
- [Shipping Tab](#shipping-tab-guide--new-feature)
- [Search Feature](#search-feature)
- [Common Workflows](#common-workflows)
- [Advanced Features](#advanced-features)
- [FAQ & Troubleshooting](#faq--troubleshooting)

---

## 🚀 Getting Started

### Starting the Application

**1. Start Backend API**
```
Visual Studio → Backend Project (Gatmaitan-M1_Partial)
Press Ctrl+F5 (Run without debugging)
Wait for: "Application started"
API URL: https://localhost:7211/
```

**2. Start Client Application**
```
Visual Studio → Client Project (Gatmaitan_M1_Client)
Press F5 (Run with debugging)
Wait for app to load
You'll see 3 tabs: Inventory | Orders | Shipping
```

**3. First Launch**
- Sample data auto-loads (5 items + 1 shipping record)
- All DataGrids populate automatically
- Ready to use!

---

## 📦 INVENTORY TAB GUIDE

### Purpose
Manage your product inventory - add, edit, delete, and track items

### Screen Layout
```
┌──────────────────────────────────────────────────┐
│ Search: [Search Box]      INVENTORY ITEMS        │
├────────────────┬─────────────────────────────────┤
│                │                                 │
│  DATAGRID      │  FORM                          │
│  ID│Name│Code  │  Name: [_____________]         │
│  1 │Lpt │ITM001│  Code: [_____________]         │
│  2 │Mse │ITM002│  Brand: [_____________]        │
│    │    │      │  Price: [_____________]        │
│    │    │      │  Qty: [_____________]          │
│    │    │      │                                │
│    │    │      │  [Add] [Update]               │
│    │    │      │  [Delete] [Clear]             │
│    │    │      │  [Load Items]                 │
└────────────────┴─────────────────────────────────┘
```

### Task 1: Add a New Item

**Step 1:** Fill in the form
```
Name: Laptop
Code: ITM001
Brand: Dell
Unit Price: 50000
Quantity: 20
```

**Step 2:** Click [Add]

**Step 3:** See message "Item added successfully!"

**Result:** New item appears in DataGrid

**Example Complete:**
```
✅ Laptop added to inventory
✅ Code: ITM001 (unique ID)
✅ Price: ₱50,000
✅ Stock: 20 units
```

### Task 2: View All Items

**Simply:** Click [Load Items] button

**Result:** All items appear in DataGrid with columns:
- ID (unique number)
- Name (product name)
- Code (product code)
- Brand (manufacturer)
- Unit Price (price per unit)
- Quantity (current stock)

### Task 3: Update an Item

**Step 1:** Click on any row in DataGrid

**Step 2:** Form auto-fills with that item's data

**Step 3:** Change the fields you want to update
```
Example: Change Quantity from 20 → 15
```

**Step 4:** Click [Update]

**Result:** Item is updated in database

**Example:**
```
Select: Laptop (ID 1)
Change: Quantity 20 → 15
Click [Update]
✅ Updated! Laptop now shows 15 units
```

### Task 4: Delete an Item

**Step 1:** Click on the item row

**Step 2:** Click [Delete]

**Step 3:** Confirmation dialog appears:
```
"Delete this item?"
[Yes] [No]
```

**Step 4:** Click [Yes] to confirm

**Result:** Item removed permanently

⚠️ **WARNING:** Deleted items cannot be recovered!

### Task 5: Clear Form

**Simply:** Click [Clear] button

**Result:** All form fields empty, no item selected

### Task 6: Search for Items

**In the Search Box at top, type:**

Search for Item Name:
```
Type: "Laptop"
Result: Shows all Laptop-related items
```

Search by Code:
```
Type: "ITM001"
Result: Shows only that item code
```

Search by Brand:
```
Type: "Dell"
Result: Shows all Dell products
```

**Real Examples:**
```
Search "dell" → All Dell items
Search "ITM" → All items with ITM code
Search "Mouse" → All mouse products
Search "50" → Items with 50 in any field
```

---

## 📦 ORDERS TAB GUIDE

### Purpose
Create and manage customer orders. When you order, inventory automatically reduces!

### Screen Layout
```
┌──────────────────────────────────────────────────┐
│ Search: [Search Box]      ORDERS                 │
├────────────────┬─────────────────────────────────┤
│                │                                 │
│  DATAGRID      │  FORM                          │
│ ID │Item │Qty  │  Item Code: [_______]          │
│ 1  │Lpt  │ 5   │  Item Name: [_______] (auto)   │
│ 2  │Mse  │10   │  Ordered By: [_______]         │
│    │     │     │  Quantity: [_______]           │
│    │     │     │  Unit Price: [_______] (auto)  │
│    │     │     │                                │
│    │     │     │  [Add Order] [Update]         │
│    │     │     │  [Delete] [Clear]             │
│    │     │     │  [Load Orders]                │
└────────────────┴─────────────────────────────────┘
```

### Task 1: Create a New Order

**Step 1:** Fill in the form
```
Item Code: ITM001
Ordered By: Juan Dela Cruz
Quantity: 5
```

**Step 2:** Click [Add Order]

**Step 3:** System checks:
- ✅ Item exists?
- ✅ Enough stock?

**Step 4:** If OK:
- ✅ Order created
- ✅ Inventory reduced (auto)
- ✅ Shipping auto-created
- Success message appears

**Result Message:**
```
"Order created! Inventory reduced. 
Shipping auto-generated.

Click 'Load Items' to see updated inventory."
```

**What Happened Behind Scenes:**
```
Order Created: ITM001 × 5 by Juan
Inventory: Was 20 → Now 15 (reduced by 5)
Shipping: Auto-created, Status: Pending
```

### Task 2: View All Orders

**Simply:** Click [Load Orders]

**Result:** All orders show in DataGrid

**Columns:**
- ID (order number)
- Item Code (product code)
- Item Name (product name)
- Ordered By (customer name)
- Quantity (how many ordered)
- Unit Price (price per unit)
- Total (quantity × price)

### Task 3: Check Inventory After Order

**IMPORTANT:** After creating order:
1. Go to **Inventory Tab**
2. Click [Load Items]
3. See the quantity has decreased ✓

**Example:**
```
Before Order: Laptop Qty = 20
Order: 5 Laptops
After [Load Items]: Laptop Qty = 15
```

### Task 4: Update an Order

**Step 1:** Click any order row

**Step 2:** Form auto-fills

**Step 3:** Modify:
- Ordered By (customer name)
- Quantity (how many)

**Step 4:** Click [Update]

**Result:** Order is updated

**Note:** Item Code and Price are read-only (can't change)

### Task 5: Cancel an Order

**Step 1:** Click an order row

**Step 2:** Click [Delete]

**Step 3:** Confirmation dialog:
```
"Cancel this order?

This will:
- Delete the order
- Restore inventory quantity

Click 'Load Items' after to see changes.

[Yes] [No]"
```

**Step 4:** Click [Yes]

**Step 5:** Order deleted and inventory restored

**After Cancellation:**
1. Go to **Inventory Tab**
2. Click [Load Items]
3. Quantity increased back ✓

**Example:**
```
Before Cancel: Inventory = 15
Cancel: Order for 5 units
After [Load Items]: Inventory = 20
```

### Task 6: Stock Validation

**If you try to order more than available:**

```
Available: 10 units
Try to order: 15 units
    ↓
Error: "Insufficient stock! Only 10 available."
    ↓
Order NOT created
```

**Solution:** Order less or add more to inventory first

### Task 7: Search Orders

Search by Item Name:
```
Type: "Laptop"
Result: All laptop orders
```

Search by Item Code:
```
Type: "ITM001"
Result: Orders for that item
```

Search by Customer Name:
```
Type: "Juan"
Result: All orders from Juan
```

**Real Examples:**
```
Search "maria" → All Maria's orders
Search "ITM001" → All ITM001 orders
Search "Laptop" → All laptop orders
```

---

## 🚚 SHIPPING TAB GUIDE - NEW FEATURE (v4.0)

### Purpose
Track and manage shipments. Now with intelligent cancellation!

### Screen Layout
```
┌──────────────────────────────────────────────────┐
│ Search: [Search Box]      SHIPPING               │
├────────────────┬─────────────────────────────────┤
│                │                                 │
│  DATAGRID      │  FORM                          │
│ ID │Item │To   │  Item Code: [_______] (auto)   │
│ 1  │Lpt  │     │  Item Name: [_______] (auto)   │
│ 2  │Mse  │Mla  │  Ordered By: [_______] (auto)  │
│    │     │     │  Ship To: [_______]            │
│    │     │     │  Status: [Pending ▼]           │
│    │     │     │                                │
│    │     │     │  [Update] [Delete]            │
│    │     │     │  [Clear] [Load Shipping]      │
└────────────────┴─────────────────────────────────┘
```

### Important: Status Dropdown Values

| Status | Meaning | When to Use |
|--------|---------|------------|
| **Pending** | Ready to ship | Initial state |
| **In Transit** | On the way | After shipped |
| **Delivered** | Received | After delivered |
| **Cancelled** | ⭐ **NEW** | To cancel order + restore inventory |

### Task 1: Update Shipping Destination & Status

**Step 1:** Click a shipping row

**Step 2:** Form auto-fills with order details

**Step 3:** Fill or update:
- **Ship To:** Destination address (e.g., "Manila")
- **Status:** Select from dropdown

**Step 4:** Click [Update]

**Result:** Shipping record updated

**Example:**
```
Select: Shipping ID 1 (Laptop order)
Fill: Ship To = "Makati, Manila"
Status: Pending (leave as is)
Click [Update]
✅ Saved!
```

### Task 2: Track Shipping Status (Normal Updates)

**Workflow: Pending → In Transit → Delivered**

**Step 2a: Initially (when order created)**
- Status: Pending
- Fill in "Ship To" address
- Click [Update]

**Step 2b: When shipping out**
- Click the record again
- Change Status: Pending → **In Transit**
- Click [Update]

**Step 2c: When delivered**
- Click the record again
- Change Status: In Transit → **Delivered**
- Click [Update]

**Example Complete Flow:**
```
Step 1: Pending + "Manila" → Click [Update]
Step 2: In Transit + "Manila" → Click [Update]
Step 3: Delivered + "Manila" → Click [Update]
✅ Complete!
```

### Task 3: ⭐ CANCEL A SHIPMENT (NEW - v4.0)

**This is the new feature! When you change status to "Cancelled":**
- Associated order is DELETED
- Inventory is RESTORED
- Shipping shows "Cancelled"

**Step 1:** Click a shipping record

**Step 2:** Change Status: (any) → **"Cancelled"**

**Step 3:** Click [Update]

**Step 4:** Confirmation dialog appears:
```
┌──────────────────────────────────────────┐
│ Cancel Shipment                          │
├──────────────────────────────────────────┤
│ You are cancelling this shipment.        │
│                                          │
│ This will:                               │
│ - Delete the associated order            │
│ - Restore inventory quantity             │
│                                          │
│ Click 'Load Orders' and 'Load Items'     │
│ after to see changes.                    │
│                                          │
│ [Yes]  [No]                             │
└──────────────────────────────────────────┘
```

**Step 5:** Click [Yes] to confirm

**Result Message:**
```
"Shipment cancelled!

Associated order deleted and inventory restored.

Click 'Load Orders' in Orders tab and 
'Load Items' in Inventory tab to see changes."
```

**Step 6:** Verify by refreshing:
1. Go to **Orders Tab** → Click [Load Orders]
   - Associated order is GONE ✓
2. Go to **Inventory Tab** → Click [Load Items]
   - Quantity is RESTORED ✓

**Complete Example:**
```
Before Cancel:
- Shipping 1: Laptop to Manila (Pending)
- Order 1: Laptop × 3 (by Juan)
- Inventory: Laptop = 17

Action:
- Change Shipping Status → "Cancelled"
- Click [Update] → Confirm [Yes]

After Cancel (and refreshing):
- Shipping 1: Status = "Cancelled" ✓
- Order 1: DELETED! ✓
- Inventory: Laptop = 20 (restored) ✓
```

### Task 4: Delete Shipping Record (Manual Cleanup)

**When to use:** Only for completed deliveries or errors

**Step 1:** Click a shipping row

**Step 2:** Click [Delete]

**Step 3:** Confirm dialog appears

**Step 4:** Click [Yes]

**Result:** Shipping record deleted

**Note:** This is different from "Cancelled" status. Use "Cancelled" to cancel orders!

### Task 5: Search Shipping Records

Search by Item Name:
```
Type: "Laptop"
Result: All laptop shipments
```

Search by Item Code:
```
Type: "ITM001"
Result: Shipments for that item
```

Search by Destination:
```
Type: "Manila"
Result: All shipments to Manila
```

Search by Status:
```
Type: "Pending"
Result: All pending shipments
```

**Real Examples:**
```
Search "manila" → All Manila shipments
Search "pending" → All pending shipments
Search "delivered" → All delivered items
Search "ITM001" → All shipments for that item
```

---

## 🔍 SEARCH FEATURE

### How Search Works

**Real-time filtering** - Results update as you type (no button needed!)

**Features:**
- ✅ Case-insensitive (type "dell" or "DELL" - both work)
- ✅ Partial matching (type "man" finds "Manila")
- ✅ Works on multiple fields
- ✅ Clear search box to see all records

### By Tab

**INVENTORY Search - Find items by:**
- Product name
- Product code
- Brand name

**ORDERS Search - Find orders by:**
- Item name
- Item code
- Customer name

**SHIPPING Search - Find shipments by:**
- Item name
- Item code
- Destination
- Status

### Examples

```
Inventory Search:
  Type "dell" → Shows Dell Laptop, Dell Mouse, etc.
  Type "ITM00" → Shows ITM001, ITM002, etc.

Orders Search:
  Type "maria" → Shows all Maria's orders
  Type "keyboard" → Shows all keyboard orders

Shipping Search:
  Type "manila" → Shows all Manila shipments
  Type "cancelled" → Shows all cancelled shipments
  Type "pending" → Shows all pending shipments
```

---

## 💡 COMMON WORKFLOWS

### Workflow 1: Complete Order-to-Delivery

**Goal:** Process an order from creation to delivery

**Step 1: Create Order (Orders Tab)**
```
Item Code: ITM001
Ordered By: Maria Garcia
Quantity: 3
Click [Add Order]
Result: Order created, Inventory: 20 → 17
```

**Step 2: Verify Inventory (Inventory Tab)**
```
Click [Load Items]
Result: Laptop shows Quantity 17 ✓
```

**Step 3: Update Shipping (Shipping Tab)**
```
Click new shipping record
Ship To: "Makati, Manila"
Status: Pending
Click [Update]
```

**Step 4: Ship the Item (Shipping Tab)**
```
Click the record
Status: Pending → "In Transit"
Click [Update]
Result: Shipment on the way
```

**Step 5: Delivery (Shipping Tab)**
```
Click the record
Status: In Transit → "Delivered"
Click [Update]
Result: Order complete!
```

### Workflow 2: Cancel an Order Due to Refund

**Goal:** Customer wants to cancel after order creation

**Step 1: Find Shipment (Shipping Tab)**
```
Search for customer: "Maria"
Click their shipping record
```

**Step 2: Cancel Shipment**
```
Change Status: (any) → "Cancelled"
Click [Update]
Confirm: [Yes]
System automatically:
  - Deletes order
  - Restores inventory
```

**Step 3: Verify (Both tabs)**
```
Orders Tab: Click [Load Orders] → Order gone ✓
Inventory Tab: Click [Load Items] → Qty restored ✓
```

**Step 4: Process Refund (Manual)**
```
Process customer refund separately
(System only handles order/inventory)
```

### Workflow 3: Manage Low Stock

**Goal:** Check and restock low items

**Step 1: Review Inventory (Inventory Tab)**
```
Click [Load Items]
Review Quantity column
Identify low stock items
```

**Step 2: Add More Stock**
```
Click the low stock item
Increase Quantity
Click [Update]
Result: Stock increased
```

**Step 3: Alternative - Prevent Orders**
```
Don't add to inventory, just:
- Tell customers "out of stock"
- Won't allow orders (system prevents it)
```

### Workflow 4: Track Pending Shipments

**Goal:** See all shipments not yet delivered

**Step 1: Shipping Tab**
```
Search: "Pending"
Result: Shows all pending shipments
```

**Step 2: Process Each**
```
For each pending:
  Click the record
  Update status: Pending → In Transit
  Click [Update]
```

**Step 3: Final Step**
```
Later, when delivered:
  Update status: In Transit → Delivered
  Click [Update]
```

---

## 🎯 ADVANCED FEATURES

### Feature 1: Multiple Item Types

You can manage different product types:

```
Electronics:
- Laptop (ITM001)
- Mouse (ITM002)
- Keyboard (ITM003)

Office Supplies:
- Paper (ITM010)
- Pens (ITM011)

Organize by codes!
```

### Feature 2: Bulk Operations

**Add multiple items at once:**
```
1. Add Item 1 → Click [Add]
2. Add Item 2 → Click [Add]
3. Add Item 3 → Click [Add]
(Each one automatically)
```

### Feature 3: Cascade Updates

When you cancel a shipment:
```
Shipping: Status = Cancelled
    ↓
Order: DELETED
    ↓
Inventory: RESTORED
    ↓
All synchronized automatically!
```

### Feature 4: Data Persistence

**Your data is always saved:**
- No manual save button needed
- Auto-saved to database
- Survives app restart
- Crash-safe

---

## ❓ FAQ & TROUBLESHOOTING

### Q1: What if app won't start?
**A:** Make sure backend API is running on https://localhost:7211/

```
Backend: Ctrl+F5 in backend project
Wait for "Application started"
Then start client app
```

### Q2: Orders aren't showing?
**A:** Click [Load Orders] button in Orders Tab

```
It's intentional - you control when to refresh
After any changes, click Load buttons
```

### Q3: Inventory quantity didn't change?
**A:** Click [Load Items] in Inventory Tab after order

```
Changes happen in database immediately
But UI updates when you click Load
This is by design (prevents auto-distractions)
```

### Q4: Can I undo a deletion?
**A:** No, deleted items are permanent

```
Be careful when deleting!
Create new item if deleted by mistake
```

### Q5: What if order quantity exceeds stock?
**A:** System prevents it

```
Error: "Insufficient stock! Only X available."
Order is NOT created
Solution: Order less or add more inventory
```

### Q6: Can I change a customer name after order?
**A:** Yes, in Orders Tab

```
Click order → Change "Ordered By"
Click [Update] → Done!
```

### Q7: What does "Cancelled" shipment status do?
**A:** Automatically cancels the order and restores inventory

```
Status: (any) → "Cancelled"
Click [Update] → Confirm
Result:
  - Order deleted
  - Inventory restored
  - Shipping shows "Cancelled"
```

### Q8: Are there refunds?
**A:** No, system only handles orders/inventory

```
For refunds:
- Handle separately with payment provider
- System deletes order and restores inventory
- You process the actual refund
```

### Q9: Can multiple people use this?
**A:** Not currently (single-user)

```
For multi-user:
- Set up shared network database
- Requires additional configuration
- Talk to administrator
```

### Q10: Where is my data stored?
**A:** In SQL Server database

```
Default: Local SQL Server instance
Survives app crashes
Backed up automatically
```

### Q11: What if search doesn't work?
**A:** Make sure you:

```
1. Typing in the search box (top of tab)
2. Search is real-time (no button)
3. Clear search to see all
4. Check spelling
```

### Q12: How do I know if backend is running?
**A:** Check Visual Studio backend project

```
Running: Shows "Application started" message
Not running: Press Ctrl+F5 to start
```

---

## 📚 Summary Table

| Task | Tab | Button | Result |
|------|-----|--------|--------|
| Add item | Inventory | [Add] | Item created |
| Edit item | Inventory | [Update] | Item modified |
| Delete item | Inventory | [Delete] | Item removed |
| Load items | Inventory | [Load Items] | Refresh list |
| Create order | Orders | [Add Order] | Order + Inventory reduced + Shipping auto-created |
| Edit order | Orders | [Update] | Order modified |
| Cancel order | Orders | [Delete] | Order deleted + Inventory restored |
| Load orders | Orders | [Load Orders] | Refresh list |
| Update shipping | Shipping | [Update] | Details updated |
| **Cancel shipment** | **Shipping** | **[Update] with "Cancelled"** | **Order deleted + Inventory restored** |
| Load shipping | Shipping | [Load Shipping] | Refresh list |

---

## 🎓 Tips for Success

1. **Always click Load after changes** - UI needs to refresh
2. **Use search to find items quickly** - Saves time
3. **Read error messages** - They tell you what's wrong
4. **Confirm dialogs carefully** - They prevent mistakes
5. **Organize item codes** - Makes searching easier
6. **Use "Cancelled" for order cancellations** - Automates cleanup
7. **Keep backend running** - Required to use system
8. **Document unusual situations** - Helps with troubleshooting

---

## 🚀 You're Ready!

You now know how to:
✅ Manage inventory completely  
✅ Create and track orders  
✅ Manage shipping and delivery  
✅ Cancel orders with automatic restoration  
✅ Use search effectively  
✅ Handle common scenarios  

**Start using your inventory system with confidence!** 📊

---

**Last Updated:** November 11, 2025  
**Version:** 4.0 Complete Guide  
**Status:** Production Ready ✅

For technical details, see README.md
For API reference, see GitHub documentation
For developer info, see architecture docs
