# Part 02 — answers

---

## Reports

- What was the problem?

  The `CsvReportExporter`, `JsonReportExporter`, and `TextReportExporter` classes duplicated 
  the same export workflow, including loading data, validating it, formatting it, and saving the file.
  This duplication made the code harder to maintain and allowed the export steps to become inconsistent.


- What did you change?

  Introduced an abstract class named `ReportExporter` that contains the common export workflow in 
  one `Export()` method. It also contains the shared `Load()`, `Validate()`, and `Save()` methods. 
  The `Format()` method is abstract, so each concrete exporter implements only its own formatting logic. 
  The three exporters continue to produce CSV, JSON, and text reports.

- Why did you choose that approach?

  The Template Method pattern keeps the export steps and their execution order in one place while
  allowing subclasses to customize the formatting step. 
  An abstract class is a better fit than an interface here because it can provide shared implementation and state the fixed workflow, 
  while an interface primarily defines a contract. 
  This reduces code duplication and makes the exporters easier to maintain.

---

## Enrollment


- What was the problem?

  `Program.cs` created and called `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService` 
  directly. It had to know the correct order of the enrollment steps and the details of each service, 
  making the caller more complex and tightly coupled to the services.

- What did you change?

  Introduced an `EnrollmentFacade` class that creates the four services and coordinates the enrollment
  workflow through a single `Enroll()` method. Updated `Program.cs` to call the facade once instead of
  creating or calling the individual services. The four services in `Services.cs` remain unchanged, 
  and the original enrollment output is preserved.

- Why did you choose that approach?

  The Facade pattern provides a simple interface to a group of services.
  It hides the details and order of the enrollment operations from the caller, 
  reduces complexity and coupling in `Program.cs`, and makes the enrollment flow easier to read and maintain.
