namespace RingCentral
{
    public partial class CustomGreetingRequest
    {
        // Type of a greeting, specifying the case when the greeting is played. See Greeting Types = ['Introductory', 'Announcement', 'ConnectingMessage', 'ConnectingAudio', 'Voicemail', 'Unavailable', 'HoldMusic']
        public string @type { get; set; }
        // Information on an answering rule that the greeting is applied to
        public CustomGreetingAnsweringRuleInfoRequest @answeringRule { get; set; }
    }
}
