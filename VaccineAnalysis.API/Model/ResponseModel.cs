namespace VaccineAnalysis.API.Model
{
    public class ResponseModel
    {
        public string Messae { get; set; }
        public int ResponseCode { get; set; }
        public Exception Exception { get; set; }
        public object Result { get; set; }
    }
}
