using RefactoringLab;
using RefactoringLab.Part01.src;
using RefactoringLab.Part01.src._1_ShippingCostCalculator;
using RefactoringLab.Part01.src._2_OrderProcessor;
using RefactoringLab.Part01.src._3_Notifications;



/* ==================== BEFORE REFACTORING ==================== */

// var shipping = new ShippingCostCalculator();
// Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
// Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
// Console.WriteLine();


/* ==================== AFTER REFACTORING ==================== */

var shipping = new ShippingCostCalculator();

IShippingCarrier aramex = new AramexCarrier();
IShippingCarrier fedEx = new FedExCarrier();
IShippingCarrier dhl = new DhlCarrier();

Console.WriteLine($"Aramex 2kg → {shipping.Calculate(aramex, 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(fedEx, 2)}");
Console.WriteLine($"DHL 2kg    → {shipping.Calculate(dhl, 2)}");
Console.WriteLine();


/* ==================== BEFORE REFACTORING ==================== */

// var processor = new OrderProcessor();
// processor.Process(1001, "customer@example.com");
// Console.WriteLine();


/* ==================== AFTER REFACTORING ==================== */

IOrderRepository repo = new SqlOrderRepository();
IEmailSender email = new SmtpEmailSender();

var processor = new OrderProcessor(repo, email);
processor.Process(1001, "customer@example.com");
Console.WriteLine();



/* ==================== BEFORE REFACTORING ==================== */

// var email = new UrgentScheduledEmailNotification
// {
//     SendAt = DateTime.Today.AddHours(18)
// };
// email.Send("customer@example.com", "Your order ships tomorrow");

// var sms = new UrgentSmsNotification();
// sms.Send("+201000000000", "OTP 4821");


/* ==================== AFTER REFACTORING ==================== */

// Urgent scheduled email
INotification urgentScheduledEmail = new EmailNotification();

urgentScheduledEmail = new UrgentDecorator(urgentScheduledEmail);

urgentScheduledEmail = new ScheduledDecorator(
    urgentScheduledEmail,
    DateTime.Today.AddHours(18));

urgentScheduledEmail.Send(
    "customer@example.com",
    "Your order ships tomorrow");

// Urgent SMS with retry
INotification urgentSms = new SmsNotification();

urgentSms = new UrgentDecorator(urgentSms);
urgentSms = new RetryDecorator(urgentSms, 3);

urgentSms.Send("+201000000000", "OTP 4821");



Console.WriteLine("=== Retry Test ===");

INotification testNotification = new FailOnceNotification();
testNotification = new RetryDecorator(testNotification, 3);

testNotification.Send(
    "customer@example.com",
    "Test retry");

Console.WriteLine();

/* ========Add one new carrier without editing any existing class.================ */

IShippingCarrier ups = new UpsCarrier();

Console.WriteLine($"UPS 2kg     → {shipping.Calculate(ups, 2)}");


Console.WriteLine("=== Push Notification Test ===");

INotification push = new PushNotification();
push.Send("Mostafa", "You have a new message");

Console.WriteLine();



