namespace Domain.ValueObject
{
    public class Email
    {
        public Email(string emailDescricao)
        {
            EmailDescricao = emailDescricao;
        }

        public string EmailDescricao { get; private set; }

        public override string ToString()
        {
            return EmailDescricao;
        }
    }
}
