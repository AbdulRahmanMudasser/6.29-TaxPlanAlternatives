class TaxPlan
{
    // declaring variables
    private double housing;
    private double food;
    private double clothing;
    private double transportation;
    private double education;
    private double healthCare;
    private double vacations;

    // properties
    public double Housing { get => housing; set => housing = value; }
    public double Food { get => food; set => food = value; }
    public double Clothing { get => clothing; set => clothing = value; }
    public double Transportation { get => transportation; set => transportation = value; }
    public double Education { get => education; set => education = value; }
    public double HealthCare { get => healthCare; set => healthCare = value; }
    public double Vacations { get => vacations; set => vacations = value; }

    // constructor
    public TaxPlan(double housing, double food, double clothing, double transportation, double education, double healthCare, double vacations)
    {
        Housing = housing;
        Food = food;
        Clothing = clothing;
        Transportation = transportation;
        Education = education;
        HealthCare = healthCare;
        Vacations = vacations;
    }

    // constructor
    public TaxPlan() { }

    // total expenses method
    public double TotalExpenses()
    {
        double totalExpenses = Housing + Food + Clothing + Transportation + Education + HealthCare + Vacations;
        return totalExpenses;
    }

    // fair tax
    public double FairTax()
    {
        return TotalExpenses() * 0.23;
    }
}
// end of TaxPlan class

class TaxPlanTest
{
    static void Main(string[] args)
    {
        TaxPlan taxPlan = new TaxPlan();

        // taking user input for housing expenses
        Console.Write("Enter Housing Expenses: ");
        taxPlan.Housing = Convert.ToDouble(Console.ReadLine());

        // food
        Console.Write("Enter Food Expenses: ");
        taxPlan.Food = Convert.ToDouble(Console.ReadLine());

        // clothing
        Console.WriteLine("Enter Clothing Expenses: ");
        taxPlan.Clothing = Convert.ToDouble(Console.ReadLine());

        // transportation
        Console.WriteLine("Enter Transportation Expenses: ");
        taxPlan.Transportation = Convert.ToDouble(Console.ReadLine());

        // education
        Console.WriteLine("Enter Education Expenses: ");
        taxPlan.Education = Convert.ToDouble(Console.ReadLine());

        // healthcare
        Console.WriteLine("Enter Health Care Expenses: ");
        taxPlan.HealthCare = Convert.ToDouble(Console.ReadLine());

        // vacations
        Console.WriteLine("Enter Vacations Expenses: ");
        taxPlan.Vacations = Convert.ToDouble(Console.ReadLine());
    }
}
