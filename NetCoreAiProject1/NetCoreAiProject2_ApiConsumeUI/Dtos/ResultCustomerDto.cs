namespace NetCoreAiProject2_ApiConsumeUI.Dtos
{
    //Dto : data transfer object/s
    public class ResultCustomerDto
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
