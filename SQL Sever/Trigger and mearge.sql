/*
Triggers:
- triggers are only used in backend side, and .net people not uses this.
In SQL Server, triggers are special types of stored 
procedures that automatically execute in response to certain events 
on a table or view. They are often used to enforce business rules,
maintain audit trails, or perform additional actions when data in a
table is inserted, updated, or deleted.

Types of Triggers in SQL Server
AFTER Triggers:

Execute after an INSERT, UPDATE, or DELETE operation on a table.
Commonly used to enforce referential integrity or log changes.
INSTEAD OF Triggers:

Replace the standard INSERT, UPDATE, or DELETE operations.
Useful for complex logic or controlling actions on views.
CLR Triggers (Advanced):

Trigger written in a .NET language, such as C#.
Used for specialized actions requiring .NET framework capabilities.
*/

/*
Merge Command: 
MERGE is a powerful statement that allows you to perform 
INSERT, UPDATE, and DELETE operations in a single statement, 
depending on whether a match is found between two datasets. 
It is commonly used for data synchronization and upsert
(update or insert) scenarios.

Key Components
MERGE target_table:
Specifies the target table where changes will occur.
USING source_table:
Specifies the source table or dataset used for comparison.
ON <condition>:
Defines the condition to match rows between the target and source tables.
WHEN MATCHED THEN:
Specifies what to do when a match is found (e.g., UPDATE).
WHEN NOT MATCHED BY TARGET THEN:
Specifies what to do when a row exists in the source but not in the target (e.g., INSERT).
WHEN NOT MATCHED BY SOURCE THEN:
Specifies what to do when a row exists in the target but not in the source (e.g., DELETE).

1. Upsert (Update or Insert)
Synchronize data from a staging table into a master table.

sql
Copy code
MERGE INTO Employees AS target
USING StagingEmployees AS source
ON target.EmployeeID = source.EmployeeID
WHEN MATCHED THEN
    UPDATE SET 
        target.Name = source.Name,
        target.Salary = source.Salary
WHEN NOT MATCHED BY TARGET THEN
    INSERT (EmployeeID, Name, Salary)
    VALUES (source.EmployeeID, source.Name, source.Salary);
2. Insert New, Update Existing, and Delete Missing
Sync a product catalog with a source dataset.

sql
Copy code
MERGE INTO Products AS target
USING SourceProducts AS source
ON target.ProductID = source.ProductID
WHEN MATCHED THEN
    UPDATE SET 
        target.ProductName = source.ProductName,
        target.Price = source.Price,
        target.Stock = source.Stock
WHEN NOT MATCHED BY TARGET THEN
    INSERT (ProductID, ProductName, Price, Stock)
    VALUES (source.ProductID, source.ProductName, source.Price, source.Stock)
WHEN NOT MATCHED BY SOURCE THEN
    DELETE;
3. Conditional Update
Update only specific rows when conditions are met.

sql
Copy code
MERGE INTO Employees AS target
USING SalaryUpdates AS source
ON target.EmployeeID = source.EmployeeID
WHEN MATCHED AND source.NewSalary > target.Salary THEN
    UPDATE SET 
        target.Salary = source.NewSalary;
4. Merge with OUTPUT Clause
Capture changes made by the MERGE statement.

sql
Copy code
MERGE INTO Orders AS target
USING NewOrders AS source
ON target.OrderID = source.OrderID
WHEN MATCHED THEN
    UPDATE SET target.Status = source.Status
WHEN NOT MATCHED BY TARGET THEN
    INSERT (OrderID, CustomerID, Status)
    VALUES (source.OrderID, source.CustomerID, source.Status)
OUTPUT 
    $action AS ChangeType, 
    inserted.OrderID, 
    deleted.OrderID;
Best Practices
Avoid Complex Logic:
Simplify WHEN MATCHED conditions to ensure the query remains readable and maintainable.
Use the OUTPUT Clause:
Capture changes for logging, debugging, or further processing.
Locking:
Be mindful of potential locking issues during MERGE, especially for large datasets.
Test for Performance:
For large datasets, test the performance of MERGE compared to separate INSERT, UPDATE, and DELETE operations.
Common Errors
Ambiguous Columns:
Ensure columns referenced in ON, INSERT, or UPDATE are fully qualified if they exist in both tables.
Cardinality Issues:
The ON condition must uniquely match rows to avoid unexpected behavior.

*/
































