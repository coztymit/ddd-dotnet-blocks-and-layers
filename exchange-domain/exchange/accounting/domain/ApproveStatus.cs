namespace exchange_domain.exchange.accounting.domain
{
    public class ApproveStatus
    {
       
        public static ApproveStatus APPROVED = new ApproveStatus ("APPROVED");
        public static ApproveStatus DRAFT = new ApproveStatus("DRAFT");
        private string value;

        private ApproveStatus(string value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return value;
        }
    }

}