namespace RingCentral
{
    public partial class AddBlockedAllowedPhoneNumber
    {
        // A blocked/allowed phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        public string @phoneNumber { get; set; }
        // Custom name of a blocked/allowed phone number
        public string @label { get; set; }
        // Status of a phone number
        public string @status { get; set; }
    }
}
