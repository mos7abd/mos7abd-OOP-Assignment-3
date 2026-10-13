using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;

Console.WriteLine("=== Reports ===");
var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
Directory.CreateDirectory(outDir);

new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();


Console.WriteLine("=== Enrollment ===");

/* ==================== BEFORE REFACTORING ==================== */

// var studentId = "S100";
// var courseId = "CS201";
// var amount = 1500m;

// var payment = new PaymentGateway();
// var seats = new SeatInventory();
// var invoices = new InvoiceGenerator();
// var email = new EmailService();

// payment.Charge(studentId, amount);
// seats.Reserve(courseId, studentId);
// var invoiceId = invoices.Create(studentId, amount);
// email.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");

/* ==================== AFTER REFACTORING ==================== */

var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;

var enrollment = new EnrollmentFacade();
enrollment.Enroll(studentId, courseId, amount);

Console.WriteLine();

