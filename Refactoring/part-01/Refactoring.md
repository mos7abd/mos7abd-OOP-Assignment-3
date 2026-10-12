# Part 01 — answers

---

## ShippingCostCalculator

- **What was the problem?**
  The `ShippingCostCalculator` used a switch statement to calculate shipping costs for specific carriers.
  Adding a new carrier required modifying the existing calculator class, violating the Open/Closed Principle (OCP).

- **What did you change?**
  Introduced the `IShippingCarrier` interface and implemented it in `AramexCarrier`, 
  `FedExCarrier`, `DhlCarrier`, and `UpsCarrier`. 
  The calculator now depends on the interface and delegates the cost calculation to the selected carrier.

---

## OrderProcessor

- **What was the problem?**
  The `OrderProcessor` created concrete dependencies directly inside its `Process` method. 
  This tightly coupled the class to specific implementations and made testing and replacing dependencies difficult.

- **What did you change?**
  Introduced the `IOrderRepository` and `IEmailSender` interfaces and 
  injected their implementations through the constructor. 
  This applies Dependency Inversion Principle (DIP) and Dependency Injection (DI).

---

## Notifications

- **What was the problem?**
  The notification classes used inheritance to represent combinations of notification channels,
  urgency, and scheduling. This created multiple subclasses and made adding new combinations more difficult.

- **What did you change?**
  Replaced the inheritance-based design with composition. Introduced the `INotification` interface, 
  `NotificationOptions`, and decorators for urgency, scheduling, and retry behavior. Added `PushNotification` as
  a new notification channel without modifying the existing email and SMS notification classes.

---

## Proof

- **New carrier file(s):** `IShippingCarrier.cs`, `AramexCarrier.cs`, `FedExCarrier.cs`, `DhlCarrier.cs`, `UpsCarrier.cs`.
- **New notification channel file(s):** `PushNotification.cs`.
- **Existing classes left unchanged? (yes/no):** Yes, existing email and SMS notification classes were left unchanged when adding the new Push notification channel. The original classes were refactored earlier as part of this task.