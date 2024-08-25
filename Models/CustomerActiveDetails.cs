namespace SerialKeyGenerate.Models
{
    public class CustomerActiveDetails
    {
        public int id { get; set; }
        public string? client_name { get; set; }
        public string? software_name { get; set; }
        public string? db_name { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public Boolean isactive{ get; set; }
        public DateTime print_report { get; set; }

    }
}
