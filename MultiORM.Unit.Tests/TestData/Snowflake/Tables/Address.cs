using MultiORM.Snowflake.Attributes;

namespace MultiORM.Unit.Tests.TestData.Snowflake.Tables
{
    [TableName("INTERNAL_CUSTOMER_ADDRESS")]
    internal class Address
    {
        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }
    }
}
