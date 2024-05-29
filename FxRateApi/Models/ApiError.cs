namespace FxRateApi.Models
{
    public class ApiError
    {
        public string Timestamp { get; set; }
        public string Message { get; set; }
        public string DebugMessage { get; set; }
        public int Code { get; set; }
        public List<ApiSubError> Errors { get; set; }
    }

}
