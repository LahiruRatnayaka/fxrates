namespace FxRateApi.Models
{
    public class ApiSubError
    {
        public string ResourceName { get; set; }
        public string Field { get; set; }
        public string RejectedValue { get; set; }
        public string Message { get; set; }
    }
}
