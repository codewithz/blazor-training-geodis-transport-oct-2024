# Entity Framework Core Migration Guide (Visual Studio 2022)

This guide explains how to **add migrations** and **update the database** using the **Package Manager Console** in **Visual Studio 2022**.

---

## **Setup**

Before proceeding, ensure:
1. **Entity Framework Core** is installed and configured.
2. A **DbContext** is defined in your project.
3. The **connection string** is correctly set in `appsettings.json`.

---

## **Using Migrations in Visual Studio 2022**

### **1. Opening the Package Manager Console**

1. Go to **Tools** > **NuGet Package Manager** > **Package Manager Console**.
2. The **Package Manager Console** will open at the bottom of Visual Studio.

---

### **2. Add a New Migration**

To create a new migration, use:

```powershell
Add-Migration <MigrationName>

 
### **3. Update the Database**

To make the changes to db, use:

```powershell
Update-Database
