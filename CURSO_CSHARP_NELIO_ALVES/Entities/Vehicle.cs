namespace CURSO_CSHARP_NELIO_ALVES.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}