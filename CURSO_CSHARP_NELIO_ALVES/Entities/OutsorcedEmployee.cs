namespace CURSO_CSHARP_NELIO_ALVES.Entities
{
    public class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee()
        {
        }

        public OutsorcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}