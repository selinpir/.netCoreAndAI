namespace NetCoreAiProject2_ApiConsumeUI.Dtos
{
    public class UpdateCustomerDto
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
