namespace SpaProject.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid AnswerMessageId { get; set; }
        public User User { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateEditMessage { get; set; }
        public string TextMessage { get; set; }
        public string? Icon { get; set; }
    }
}
