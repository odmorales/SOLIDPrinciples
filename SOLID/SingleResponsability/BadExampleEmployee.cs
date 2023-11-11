
namespace SOLID.SingleResponsability
{
    public class BadExampleEmployee
    {
        public string Name { get; set; } = string.Empty;
        public void CalculateSalary() { /* ... */ }
        public void GenerateReport() { /* ... */ }
    }
}
