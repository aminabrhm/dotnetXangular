namespace vega.Models
{
    public class VehicleFeature
    {
        public int VehicleId { get; set; }

        public Vehicle Vehical { get; set; } 

        public int FeatureId { get; set; }

        public Feature Feature { get; set; } 
}
}