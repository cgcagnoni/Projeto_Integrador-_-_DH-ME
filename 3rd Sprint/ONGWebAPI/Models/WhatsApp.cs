namespace ONGWebAPI.Models.WhatsApp
{
    public class Component
    {
        public string type { get; set; }
        public List<Parameter> parameters { get; set; }
    }

    public class Language
    {
        public string code { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public abstract class Message
    {
        public string messaging_product { get; set; }
        public string to { get; set; }
    }

    public class MessageTemplate : Message
    {
        public string type { get => "template"; }
        public Template template { get; set; }
    }

    public class MessageText : Message
    {
        public string type { get => "text"; }
        public Text text { get; set; }
    }

    public class Template
    {
        public string name { get; set; }
        public Language language { get; set; }
        public List<Component> components { get; set; }
    }

    public class Text
    {
        public string body { get; set; }
    }
}
