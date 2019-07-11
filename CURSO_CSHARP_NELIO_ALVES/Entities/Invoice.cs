using System.Globalization;
using System.Text;

namespace CURSO_CSHARP_NELIO_ALVES.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basic Payment: ");
            sb.AppendLine(BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Tax: ");
            sb.AppendLine(Tax.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Total Payment: ");
            sb.AppendLine(TotalPayment.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}